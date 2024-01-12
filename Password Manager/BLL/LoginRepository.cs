using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Password_Manager.DAL;

namespace Password_Manager.BLL
{
    internal class LoginRepository
    {
        // Database
        PasswordEntities DB = new PasswordEntities();

        // Verify login credentials
        public bool isRight(string username , string password)
        {
            return DB.User.Where( x => x.Username == username && x.MASTER_PASS == password).Any();
        }

        // Logged in users ID
        public int usersID(string username, string password)
        {
            return DB.User.Where(x => x.Username == username && x.MASTER_PASS == password).Select( x => x.ID ).FirstOrDefault();
        }

        // Add New User
        public void AddUser(string Username , string password, string FName, string LName)
        {
            var newUser         = new User();

            newUser.Username    = Username;
            newUser.MASTER_PASS = password;
            newUser.First_Name  = FName;
            newUser.Last_Name   = LName;

            DB.User.Add(newUser);
            DB.SaveChanges();
        }

    }
}
