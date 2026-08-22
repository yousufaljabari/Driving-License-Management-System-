using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using static DVLDBusinessLayer.clsApplicationType;

namespace DVLDBusinessLayer
{
    public class clsApplication
    {
        public enum enApplicationStatus { New=1,Canceled=2,Complete=3};
        public int ApplicationID { get; set; }

        public int ApplicantPersonID { get; set; }

        public string ApplicantFullName { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public byte ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public clsApplication()
        {
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = 0 ;
            ApplicationStatus = 0 ;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
        }

        public clsApplication(int applicationID, int applicantPersonID,string applicantFullName,
         DateTime applicationDate, int applicationTypeID,byte applicationStatus,  DateTime lastStatusDate, decimal paidFees)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicantFullName = applicantFullName;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
        }
        private bool GenerateApplication()
        {
            this.ApplicationID = clsApplicationData.generateApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus
                , this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return this.ApplicationID != 0;

        }

        public static clsApplication CreateNewApplication(int applicantPersonID, enApplicationType applicationType,
         int createdByUserID)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = applicantPersonID;
            application.ApplicationTypeID = (int)applicationType;
            application.ApplicationStatus = 1;

            application.PaidFees =
                clsApplicationType.GetApplicationFees(
                    application.ApplicationTypeID);

            application.CreatedByUserID = createdByUserID;

            if (!application.Save())
                return null;

            return application;
        }

        public static bool CancelApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsApplicationData.CancelApplication(LocalDrivingLicenseApplicationID);
        }

        
        public bool Save()
        {
            if(GenerateApplication())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsApplication FindByLocalDrivingLicenseApplicationID(
    int localDrivingLicenseApplicationID)
        {
            int applicationID = -1;
            int applicantPersonID = -1;
            string applicantFullName = "";
            DateTime applicationDate = DateTime.MinValue;
            int applicationTypeID = -1;
            byte applicationStatus = 0;
            DateTime lastStatusDate = DateTime.MinValue;
            decimal paidFees = 0;

            if (clsApplicationData.GetApplicationInfoByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID,ref applicationID,ref applicantPersonID,
                   ref applicantFullName,ref applicationDate,ref applicationTypeID,
                   ref applicationStatus,ref lastStatusDate,ref paidFees))
            {
                return new clsApplication(
                    applicationID,
                    applicantPersonID,
                    applicantFullName,
                    applicationDate,
                    applicationTypeID,
                    applicationStatus,
                    lastStatusDate,
                    paidFees
                );
            }

            return null;
        }
    }
}
