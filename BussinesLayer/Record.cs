using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;
using DataLayer;
using System.Xml.Linq;

namespace BussinesLayer
{

    public class clsRecord
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int UserID { get; set; }
        private enMode Mode {  get; set; } 
        private enum enMode { AddNew, Update }

        private clsRecord(int ID, string Email,string Username, string Password,
            DateTime Date, string Note, int UserID)
        {
            this.ID = ID;
            this.Email = Email;
            this.Username = Username;
            this.Password = Password;
            this.Date = Date;
            this.Note = Note;
            this.UserID = ID;
            this.Mode = enMode.Update;
        }
        public clsRecord()
        {
            ID = -1;
            Email = "";
            Username = "";
            Password = "";
            Date = DateTime.Now;
            Note = "";
            UserID = -1;
            Mode = enMode.AddNew;
        }

        public static bool RemoveRecord(int RecordID)
        {
            return clsRecordDataAccess.DeleteRecord(RecordID);
        }
        public static DataTable GetAllRecords()
        {
            return clsRecordDataAccess.GetAllRecords();
        }
        public static DataTable GetUsersAllRecords(int UserID)
        {
            if (UserID != -1)
                return clsRecordDataAccess.GetUsersAllRecords(UserID);
            else
                return new DataTable();
        }
        public static DataTable GetUsersAllRowsForColumn(int UserID, string col)
        {

            if (UserID != -1)
                return clsRecordDataAccess.GetUsersAllRowsForColumn(UserID, col);
            else
                return new DataTable();
        }
        public static DataTable GetUsersAllRecordsUsingLike(int UserID, string keyword)
        {
            if (UserID != -1)
                return clsRecordDataAccess.GetUsersAllRecordsUsingLike(UserID, keyword);
            else
                return new DataTable();
        }
        public static DataTable GetUsrsAllRecordsUsingColumnAndKeyward(int UserID, string col, string value, string keyword)
        {
            if (UserID != -1)
                return clsRecordDataAccess.GetUsrsAllRecordsUsingColumnAndKeyward(UserID, col, value, keyword);
            else
                return new DataTable();
        }
        public static clsRecord Find(int ID)
        {
            string Email, Username, Password, Note;
            int UserID = -1;
            DateTime Date = DateTime.Now;
            Email = Username = Password = Note = "";

            if (clsRecordDataAccess.GetRecord(ref ID, ref Email, ref Username, ref Password, ref Date, ref Note, ref UserID))
            {
                return new clsRecord(ID, Email, Username, Password, Date, Note, UserID);
            }
            else
            {
                return null;
            }
        }
        public static bool isExists(int ID)
        {
            return clsRecordDataAccess.isRecordExists(ID);
        }


        private bool _AddNewRecord()
        {
            this.ID = clsRecordDataAccess.AddNewRecord(this.Email, this.Username, this.Password, this.Date, this.Note, this.UserID);
            return (this.ID != -1);
        }
        private bool _UpdateRecord()
        {
            return clsRecordDataAccess.UpdateRecord(this.ID, this.Email, this.Username, this.Password, this.Date, this.Note, this.UserID);
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRecord())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateRecord();

                default:
                    return false;
            }
        }
        
        
    }
}
