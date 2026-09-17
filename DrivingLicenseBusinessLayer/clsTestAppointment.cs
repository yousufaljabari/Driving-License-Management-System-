using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestAppointment
    {
        enum enMode
        {
            AddNew = 0,
            Update = 1
        }
        enMode Mode;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = null;

            Mode = enMode.AddNew;
        }
        public static DataTable GetAppointmentsByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.GetAppointmentsByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,
                this.PaidFees,
                this.CreatedByUserID,
                this.IsLocked,
                this.RetakeTestApplicationID
            );

            return (this.TestAppointmentID != -1);
        }

        public static bool IsThereAnActiveAppointment(
        int LocalDrivingLicenseApplicationID,
        int TestTypeID)
        {
            return clsTestAppointmentData.IsThereAnActiveAppointment(
                LocalDrivingLicenseApplicationID,
                TestTypeID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;
            }

            return false;
        }
    }
}
