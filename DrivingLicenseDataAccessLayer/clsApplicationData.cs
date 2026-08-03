using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLDataAccessLayer.ConnestionClass;
using Microsoft.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsApplicationData
    {
        public static int generateApplication(int ApplicationPersondID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus
        , DateTime lastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1 ;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"
        INSERT INTO Applications
        (
            ApplicantPersonID,
            ApplicationDate,
            ApplicationTypeID,
            ApplicationStatus,
            LastStatusDate,
            PaidFees,
            CreatedByUserID
        )
        VALUES
        (
            @ApplicantPersonID,
            @ApplicationDate,
            @ApplicationTypeID,
            @ApplicationStatus,
            @LastStatusDate,
            @PaidFees,
            @CreatedByUserID
        );

        SELECT SCOPE_IDENTITY();
    ";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersondID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ApplicationID = InsertedID;
                }
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                connection.Close();
            }

            return ApplicationID;
        }

        public static bool CancelApplication(int LocalDrivingLicenseApplicationID)
        {
            int RowAffected = 0;

            string query = @"

              UPDATE A
        SET A.ApplicationStatus = 2
        FROM dbo.Applications AS A
        INNER JOIN dbo.LocalDrivingLicenseApplications AS LDA
            ON A.ApplicationID = LDA.ApplicationID
        WHERE LDA.LocalDrivingLicenseApplicationID =
              @LocalDrivingLicenseApplicationID
          AND A.ApplicationStatus = 1;



";

            // using automatically closes and disposes the connection,
            // even if an exception occurs.

            using (SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    try
                    {
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }


            }
            return RowAffected > 0;
        }

    }

}

