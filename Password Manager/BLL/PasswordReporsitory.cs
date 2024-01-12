using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Password_Manager.DAL;

namespace Password_Manager.BLL
{
    internal class PasswordReporsitory
    {
        PasswordEntities db = new PasswordEntities();
        
        // All Passwords
        public List<Passwords> All()
        {
            return db.Passwords.Where( x => x.isDeleted == false ).ToList();
        }

        // All Password Ordered by date and non deleted
        public List<Passwords> NonDeleted_OrderedByDate(int UserID)
        {
            return (from x in db.Passwords 
                    where !x.isDeleted && x.User_ID == UserID
                    orderby x.Created descending 
                    select x).ToList();
        }

        // All Deleted Passwords by date
        public List<Passwords> DeletedPasses(int UserID)
        {
            return (from x in db.Passwords
                    where x.isDeleted && x.User_ID == UserID
                    orderby x.Created descending
                    select x).ToList();
        }

        // Return password wanted to edit
        public Passwords GetRow(int ID)
        {
            return db.Passwords.Where( x => x.ID == ID).FirstOrDefault();
        }

        // Add new password to db
        public void AddTo(string web, string user, string pass, string type)
        {
            Passwords obj = new Passwords();

            obj.User_ID   = Properties.Settings.Default.User_ID;
            obj.Website   = web;
            obj.Username  = user;
            obj.Password  = pass;
            obj.Type      = type;
            obj.Created   = DateTime.Now;

            db.Passwords.Add(obj);
            db.SaveChanges();
        }

        // Gets list of wanted type of password
        public List<Passwords> GetTypeOf(string Type)
        {
            return db.Passwords.Where( x => x.Type == Type && x.isDeleted == false ).ToList();
        }

        // To Edit Password's info
        public void EditRow(int Id,string web ,string user, string pass, string type)
        {
            var row      = GetRow(Id);
            row.Website  = web;
            row.Username = user;
            row.Password = pass;
            row.Type     = type;

            db.SaveChanges();
        }

        // To Delete
        public void ToDelete(int ID)
        {
            var rowTo       = db.Passwords.Where( x => x.ID == ID ).FirstOrDefault();
            rowTo.isDeleted = true;
            db.SaveChanges();
        }

        // To Favorite
        public void ToFavorite(int ID, bool isFav)
        {
            var row = GetRow(ID);

            if (isFav)
                row.isFavorite = false;
            else
                row.isFavorite = true;

            db.SaveChanges();
        }

    }
}
