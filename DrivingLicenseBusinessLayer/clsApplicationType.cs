using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplicationType
    {
        public  enum enMode { Update = 1 };
        public enum enApplicationType
        {
            NewLocalDrivingLicense = 1,
            RenewDrivingLicense = 2,
            ReplacementLostLicense = 3,
            ReplacementDamagedLicense = 4,
            ReleaseDetainedLicense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }

        enMode _Mode;
        public int ID
        {
            set; get;
        }
        public string Title
        {
            set; get;
        }
        public decimal Fees
        {
            set; get;
        }
        public clsApplicationType(int ID, string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            this._Mode = enMode.Update;

        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }
        public static bool UpdateApplicationType(int ID, string Title, decimal Fees)
        {
            return clsApplicationTypeData.UpdateApplicationType(ID, Title, Fees);
        }
        public static clsApplicationType GetApplicationTypeInfoByID(int ID)
        {
            string Title = "";
            decimal Fees = 0.0m;
            if (clsApplicationTypeData.GetApplicationTypeInfoByID(ID, ref Title, ref Fees))
            {
                return new clsApplicationType(ID, Title, Fees);
            }
            else
            {
                return null;
            }
        }

        public static decimal GetApplicationFees(int applicationTypeID)
        {
            return clsApplicationTypeData.GetApplicationFees(applicationTypeID);
        }

        public bool Save()
        {
            if (_Mode == enMode.Update)
            {
                return UpdateApplicationType(this.ID, this.Title, this.Fees);
            }
            return false;
        }
    }
}
