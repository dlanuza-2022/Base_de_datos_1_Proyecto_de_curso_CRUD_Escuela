using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    public static class Admin
    {
        private static string id = "001-291099-1010F";
        private static string username = "JesusIsKing";
        private static string password = "123456789";
        private static string email;

        public static string Id { get => id; }
        public static string Username { get => username; }
        public static string Password { get => password; }
        public static string Email { get => email; set => email = value; }

        static public void login(string username, string password)
        {
           
        }

        static public void logout()
        {
            
        }


    }
}
