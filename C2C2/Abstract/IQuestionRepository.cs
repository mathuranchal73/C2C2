using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C2C2.Entities;


namespace C2C2.Abstract
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> Question { get; }

        void SaveQuestion(Question question);

        Question DeleteQuestion(int questionId);
    }
}
