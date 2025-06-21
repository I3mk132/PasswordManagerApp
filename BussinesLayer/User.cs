using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsUser
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public enMode Mode { get; set; }
        public enum enMode { AddNew, Update }

        private clsUser(int ID, string Email, string Password, string Username)
        {
            this.ID = ID;
            this.Email = Email;
            this.Password = Password;
            this.Username = Username;
            this.Mode = enMode.Update;

        }
        public clsUser()
        {
            ID = -1;
            Email = "";
            Password = "";
            Username = Username;
            Mode = enMode.AddNew;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {

                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in bytes)
                    stringBuilder.Append(b.ToString("x2"));

                return stringBuilder.ToString();
            }
        }

        public static bool RemoveUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
        public static clsUser Find(int ID)
        {
            string Email, Username, Password;
            Email = Username = Password = "";

            if (clsUserDataAccess.GetUser(ref ID, ref Email, ref Password, ref Username))
            {
                return new clsUser(ID, Email, Password, Username);
            }
            else
            {
                return null;
            }
        }
        public static clsUser Find(string Email)
        {
            string Username, Password;
            Username = Password = "";
            int ID = -1;

            if (clsUserDataAccess.GetUser(ref ID, ref Email, ref Password, ref Username))
            {
                return new clsUser(ID, Email, Password, Username);
            }
            else
            {
                return null;
            }
        }
        public static bool isExists(int ID)
        {
            return clsUserDataAccess.isUserExists(ID);
        }
        public static bool isExists(string Email)
        {
            return clsUserDataAccess.isUserExists(Email);
        }
        public static clsUser CheckAccount(string Email, string Password)
        {
            clsUser user = Find(Email);
            if (user != null)
            {
                if (user.Password == HashPassword(Password))
                {
                    return user;
                }
            }
            return null;
        }


        private bool _AddNewUser()
        {
            this.ID = clsUserDataAccess.AddNewUser(this.Email, this.Password, this.Username);
            return (this.ID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.ID, this.Email, this.Password, this.Username);
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();

                default:
                    return false;
            }
        }

    }
}
