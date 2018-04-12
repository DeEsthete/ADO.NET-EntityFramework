using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext context = new DataContext())
            {
                User user = new User
                {
                    Id = 1,
                    Login = "Admin",
                    Password = "112"
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
