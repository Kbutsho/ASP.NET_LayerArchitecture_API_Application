using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Database;

namespace DataAccessLayer.Repos
{
    public class UserRepo
    {
        public static User Get(int id)
        {
            ProjectEntities db = new ProjectEntities();
            return db.Users.FirstOrDefault(x => x.Id == id);
        }
        public static List<User> Get()
        {
            ProjectEntities db = new ProjectEntities();
            return db.Users.ToList();
        }


    }
}

