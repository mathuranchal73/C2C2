using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace C2C2
{
    public class Examination
    {
        public int SIZE = 5;
        public int mid;
        public int sid;
        public String sname;
        public int ncans;
        public List<Question> questions;
        public DateTime StartTime;
        public int curpos = 0;
        public Examination(int mid, int sid, String sname)
        {
            this.mid = mid;
            this.sid = sid;
            this.sname = sname;
            StartTime = DateTime.Now;
        }
        public void GetQuestions()
        {
            // get questions from OE_QUESTIONS table
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=C2C2;Integrated Security=True";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select question,ans1,ans2,ans3,ans4,cans from questions where sid = " + sid, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "questions");
            int nquestions = ds.Tables[0].Rows.Count;

            /* // get N no. of random number
             Random r = new Random();
             int[] positions = new int[SIZE];
             int num;
             for (int pos = 0; pos < SIZE; )
             {
                 num = Math.Abs(r.Next(nquestions));
                 // check whether the number is already in the array
                 bool found = false;
                 for (int i = 0; i < pos; i++)
                     if (num == positions[i]) { found = true; break; }

                 if (!found)
                 {
                     positions[pos] = num;
                     pos++;
                 }
             } // end of for*/

            // load data from DataSet into Question Objects
            questions = new List<Question>();
            DataRow dr;
            Question q;
            //foreach (int pos in positions)
            for (int i = 0; i <= 4; i++)
            {

                dr = ds.Tables[0].Rows[i];

                q = new Question(dr["question"].ToString(), dr["ans1"].ToString(), dr["ans2"].ToString(), dr["ans3"].ToString(), dr["ans4"].ToString(), dr["cans"].ToString());
                questions.Add(q);

            }






        }
    }
}
