using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C2C2.Entities;
using C2C2.Models.ManageViewModels;

namespace C2C2.Abstract
{
    public interface ISubjectRepository
    {

        IEnumerable<Subject> Subject { get; }

        void SaveSubject(Subject subject, IndexViewModel model);

        Subject DeleteSubject(int subjectId);
    }
}
