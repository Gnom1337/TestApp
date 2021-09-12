using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(UsersContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Tables.Any())
            {
                return;   // DB has been seeded
            }

            var tables = new Table[]
            {
            new Table{Name="Apple",Cost="1337",About="Good apple"},
            new Table{Name="Apple",Cost="1337",About="Good apple"}
            };
            foreach (Table s in tables)
            {
                context.Tables.Add(s);
            }
            context.SaveChanges();

        }
           
    }
}
