using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C2C2.Entities;

namespace C2C2.Abstract
{
    public class IExamRepository
    {

        IEnumerable<Exam> exam { get; }

        void SaveExam(Exam exam){}

       // Question DeleteExam(int examId);
    }
}
