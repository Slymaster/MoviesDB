using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDB
{
    class Program
    {
        static void Main(string[] args)
        {

            DataModelContainer ctx = new DataModelContainer();

            User user = new User();
            user.Login = "bibi";
            user.Password = "test";

            //var query = ctx.UserSet.Where(u => u.Password.Contains("t")).Select(u => u.Login).ToList();
            
            ctx.UserSet.Add(user);

            ctx.SaveChanges();

        }
    }
}
