using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C2C2.Entities;

namespace C2C2.Models
{
    public class MvcQuestionContext : DbContext
    {
        public MvcQuestionContext (DbContextOptions<MvcQuestionContext> options)
            : base(options)
        {
        }

        public DbSet<C2C2.Entities.Question> Question { get; set; }
    }
}
