using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using DVLDDataAccessLayer;
namespace DVLDBusinessLayer
{
    public class clsUserInfo
    {
       public  enum enMode {AddNewUser=0,UpdateUser=1};
        clsPerson _Person;
        enMode _Mode;

        public int UserID{set;get;}

        public int PersonID { set; get; }
        public string UserName{ set;get;}
        public string Password{ set;get;  }
        public bool IsActive { set; get; }

        public clsUserInfo()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive=false;
        }
        public clsUserInfo(int UserID,int PersonID,string Username,string Password,bool isActive )
        {
            this.UserID = UserID;
            this.PersonID =PersonID;
            this.UserName = Username;
           this.Password = Password;
            this.IsActive = isActive;
            this._Mode = enMode.UpdateUser;
        }
        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (UserID > 0);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive);
        }

        public static bool checkUserLogin(string Username, string Password)
        {
            return (clsUserData.checkUserLogin(Username, Password));
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = clsUserData.GetAllUsers();
            return dt;


        }

        public static clsUserInfo Find(int UserID)
        {
            int PersonID =-1;
            string UserName="";
            string Password = "";
            bool isActive = false;
            if(clsUserData.Find(UserID,ref PersonID,ref UserName,ref Password, ref isActive))
            {
                return new clsUserInfo(UserID, PersonID, UserName, Password, isActive);
            }
            else
            {
                return null;
            }
            

        }

        public static DataTable GetUserByUserID(int UserID)
        {
            return clsUserData.GetUserByUserID(UserID);
        }
        public static DataTable GetUserByUsername(string Username)
        {
            // Use For Filtring in  List 
            return clsUserData.GetUserByUsername(Username);
        }
        public static DataTable GetUserByPersonID(int UserID)
        {
            return clsUserData.GetUserByUserID(UserID);
        }
        public static DataTable GetUserByFullName(string FullName)
        {
            return clsUserData.GetUserByFullName(FullName);
        }

        public static DataTable GetUserByisActive(bool? isActive=null)
        {
            return clsUserData.GetUserByisActive(isActive);
        }

        public static bool isPersonIDRelatedWithUser(int PersonID)
        {
          return  clsUserData.isPersonIDRelatedWithUser(PersonID);
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static string GetPassword(int UserID)
        {
            string Password = clsUserData.GetPaswword(UserID);
            return Password;
        }
       
        public static int GetUserIDByUsernameAndPassword(string Username,string Password)
        {
            return clsUserData.GetUserIDByUsernameAndPassword(Username, Password);
        }
        public static bool checkUserNameIsFound(string Username)
        {
            return clsUserData.checkUserNameIsFound(Username);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNewUser:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.UpdateUser;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.UpdateUser:
                    {
                        return _UpdateUser();
                       
                    }

            }
            return false;

        }
    }
}
