using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {
        public enum enMode { Update = 1 };
        enMode _Mode;
        public int ID
        {
            set; get;
        }
        public string Title
        {
            set; get;
        }
        public string Description
        {
            set; get;
        }
        public decimal Fees
        {
            set; get;
        }
        public clsTestType(int ID, string Title,string Description,decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            this.Description = Description;
            this._Mode = enMode.Update;

        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }
        public static bool UpdateTestType(int ID, string Title,string Description, decimal Fees)
        {
            return clsTestTypeData.UpdateTestType(ID,Title,Description,Fees);
        }
        public static clsTestType GetTestTypeInfoByID(int ID)
        {
            string Title = "";
            string Description = "";
            decimal Fees = 0.0m;
            if (clsTestTypeData.GetTestTypeInfoByID(ID, ref Title,ref Description, ref Fees))
            {
                return new clsTestType (ID, Title,Description, Fees);
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            if (_Mode == enMode.Update)
            {
                return UpdateTestType(this.ID, this.Title,this.Description,this.Fees);
            }
            return false;
        }
    }
}

