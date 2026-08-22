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
SET 
    A.ApplicationStatus = 2,
    A.LastStatusDate = GETDATE()
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

        public static bool GetApplicationInfoByLocalDrivingLicenseApplicationID(
    int localDrivingLicenseApplicationID,
    ref int applicationID,
    ref int applicantPersonID,
    ref string fullName,
    ref DateTime applicationDate,
    ref int applicationTypeID,
    ref byte applicationStatus,
    ref DateTime lastStatusDate,
    ref decimal paidFees)
        {
            bool isFound = false;

            string query = @"
        SELECT
            App.ApplicationID,
            App.ApplicantPersonID,
            CONCAT(
                P.FirstName, ' ',
                P.SecondName, ' ',
                P.ThirdName, ' ',
                P.LastName
            ) AS FullName,
            App.ApplicationDate,
            App.ApplicationTypeID,
            App.ApplicationStatus,
            App.LastStatusDate,
            App.PaidFees

        FROM Applications AS App

        INNER JOIN LocalDrivingLicenseApplications AS LDLA
            ON App.ApplicationID = LDLA.ApplicationID

        INNER JOIN People AS P
            ON App.ApplicantPersonID = P.PersonID

        WHERE LDLA.LocalDrivingLicenseApplicationID =
              @LocalDrivingLicenseApplicationID;";

            using (SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@LocalDrivingLicenseApplicationID",
                        localDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                applicationID =
                                    Convert.ToInt32(reader["ApplicationID"]);

                                applicantPersonID =
                                    Convert.ToInt32(reader["ApplicantPersonID"]);

                                fullName =
                                    Convert.ToString(reader["FullName"]);

                                applicationDate =
                                    Convert.ToDateTime(reader["ApplicationDate"]);

                                applicationTypeID =
                                    Convert.ToInt32(reader["ApplicationTypeID"]);

                                applicationStatus =
                                    Convert.ToByte(reader["ApplicationStatus"]);

                                lastStatusDate =
                                    Convert.ToDateTime(reader["LastStatusDate"]);

                                paidFees =
                                    Convert.ToDecimal(reader["PaidFees"]);
                            }
                        }
                    }
                    catch
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }
       
    }


}

