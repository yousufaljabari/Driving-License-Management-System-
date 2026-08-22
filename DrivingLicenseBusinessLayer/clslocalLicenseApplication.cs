using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusinessLayer
{
    public class clslocalLicenseApplication
    {
        public enum enMode { Add = 0, Update = 1 };
        enMode Mode;

        public int LocalDrivingLicenseApplicationID { get; set; }

        public int ApplicationID { get; set; }

        public int LicenseClassID { get; set; }


        public clslocalLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;

            Mode = enMode.Add;
        }
        public clslocalLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }

        public static DataTable GetAllLocalLicenseApplication(string FilterBy = "", string FilterValue = "")
        {
            return clsLocalLicenseApplicationData.GetAllLocalLicenseApplication(FilterBy,FilterValue);
        }

        private bool _AddNewLocalLicenseApplication()
        {
           this.LocalDrivingLicenseApplicationID =
                clsLocalLicenseApplicationData
                .generateLocalLicenseApplication(
                    ApplicationID,
                    LicenseClassID);

            return LocalDrivingLicenseApplicationID != -1;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:

                    if (_AddNewLocalLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return false;
            }

            return false;
        }
        public static bool DoesHaveActiveApplicationForLicenseClass(
    int personID,
    int licenseClassID)
        {
            return clsLocalLicenseApplicationData
                .DoesHaveActiveApplicationForLicenseClass(
                    personID,
                    licenseClassID);
        }

        public static clslocalLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID=-1;
            int LicenseClassID=-1;

            if (clsLocalLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                return new clslocalLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }
        public static int PassedTest(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalLicenseApplicationData.GetPassedTest(LocalDrivingLicenseApplicationID);   
        }
    }
}
