using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLDataAccessLayer.ConnestionClass;
using Microsoft.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsTestData
    {
        public static int GetTestTrials(
    int LocalDrivingLicenseApplicationID,
    int TestTypeID)
        {
            int Trials = 0;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName))
            {
                string query = @"
            SELECT COUNT(T.TestID)
            FROM Tests T
            INNER JOIN TestAppointments TA
            ON T.TestAppointmentID = TA.TestAppointmentID
            WHERE TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
            AND TA.TestTypeID = @TestTypeID";

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

                        if (result != null)
                            Trials = Convert.ToInt32(result);
                    }
                    catch (Exception ex)
                    {
                        // Log Error
                    }
                }
            }

            return Trials;
        }
    }
}
