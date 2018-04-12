using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFLesson
{
    public class DataContext : DbContext
    {
        public DataContext() : base("EFLessonConnectionString")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
