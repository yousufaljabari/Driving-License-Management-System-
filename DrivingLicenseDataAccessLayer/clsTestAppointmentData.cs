using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLDataAccessLayer.ConnestionClass;
using DVLD_EventsLogs_;
using Microsoft.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsTestAppointmentData
    {
        public static DataTable GetAppointmentsByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT *
FROM TestAppointments_view
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";
            using (SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName))
            {
                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    try
                    {

                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogs.LogError(ex);
                    }
                }
            }
            return dt;


        }


        public static int AddNewTestAppointment(
        int TestTypeID,
        int LocalDrivingLicenseApplicationID,
        DateTime AppointmentDate,
        decimal PaidFees,
        int CreatedByUserID,
        bool IsLocked,
        int? RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            string query = @"
        INSERT INTO TestAppointments
            (TestTypeID,
             LocalDrivingLicenseApplicationID,
             AppointmentDate,
             PaidFees,
             CreatedByUserID,
             IsLocked,
             RetakeTestApplicationID)
        VALUES
            (@TestTypeID,
             @LocalDrivingLicenseApplicationID,
             @AppointmentDate,
             @PaidFees,
             @CreatedByUserID,
             @IsLocked,
             @RetakeTestApplicationID);

        SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                        LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@IsLocked", IsLocked);

                    command.Parameters.AddWithValue(
                        "@RetakeTestApplicationID",
                        (object?)RetakeTestApplicationID ?? DBNull.Value);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            TestAppointmentID = ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogs.LogError(ex);
                    }
                }
            }

            return TestAppointmentID;
        }


        public static bool IsThereAnActiveAppointment(
    int LocalDrivingLicenseApplicationID,
    int TestTypeID)
        {
            bool IsFound = false;

            string query = @"
        SELECT 1
        FROM TestAppointments
        WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
          AND TestTypeID = @TestTypeID
          AND IsLocked = 0;";

            using (SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@LocalDrivingLicenseApplicationID",
                        LocalDrivingLicenseApplicationID);

                    command.Parameters.AddWithValue(
                        "@TestTypeID",
                        TestTypeID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        IsFound = (result != null);
                    }
                    catch (Exception ex)
                    {
                        clsEventLogs.LogError(ex);
                        IsFound = false;
                    }
                }
            }

            return IsFound;
        }
    }
}
