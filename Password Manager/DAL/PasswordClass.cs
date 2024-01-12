using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.DAL
{
    public class PasswordClass
    {
        public int      ID { get; set; }
        public string   Website { get; set; }
        public string   Username { get; set; }
        public string   Password { get; set; }
        public string   Type { get; set; }
        public DateTime Created { get; set; }

        public PasswordClass(int id, string web, string user, string pass , string type, DateTime Date)
        {
            ID          = id;
            Website     = web;
            Username    = user;
            Password    = pass;
            Type        = type;
            Created = Date;
        }
        public PasswordClass()
        {

        }
    }


}
