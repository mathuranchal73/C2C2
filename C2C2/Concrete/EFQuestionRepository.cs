using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C2C2.Abstract;
using C2C2.Entities;
using C2C2.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;


namespace C2C2.Concrete
{
    public class EFQuestionRepository:IQuestionRepository
    {


        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Question> Question 
        {
            get { return context.Question; }
        }

        public void SaveQuestion(Question question)
        {
            if (question.QuestionId == 0)
            {
                context.Question.Add(question);
                context.Question.Add(question);
            }
            else
            {
                Question dbEntry = context.Question.Find(question.QuestionId);
                if (dbEntry != null)
                {
                    dbEntry.QuestionText = question.QuestionText;
                    dbEntry.ans1 = question.ans1;
                    dbEntry.ans2 = question.ans2;
                    dbEntry.ans3 = question.ans3;
                    dbEntry.ans4 = question.ans4;
                    dbEntry.cans = question.cans;
                }
            }
            context.SaveChanges();
        }

        public Question DeleteQuestion(int questionId)
        {
            Question dbEntry = context.Question.Find(questionId);
            if (dbEntry != null)
            {
                context.Question.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
