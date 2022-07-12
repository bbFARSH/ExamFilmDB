using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class CinemaDBContext : DbContext
    {
        public CinemaDBContext() : base("DefaultConnection")
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
