using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLDataAccessLayer.ConnestionClass;
using Microsoft.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsLocalLicenseApplicationData
    {
        public static DataTable GetAllLocalLicenseApplication(string FilterBy="",string FilterValue="")
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"SELECT
    LDA.LocalDrivingLicenseApplicationID AS [L.D.L.AppID],
    LC.ClassName AS [Driving Class],
    P.NationalNo AS [National No.],
    P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS [Full Name],
    A.ApplicationDate AS [Application Date],
    COUNT(DISTINCT CASE WHEN T.TestResult = 1 THEN TA.TestTypeID END) AS [Passed Tests],
    CASE A.ApplicationStatus
        WHEN 1 THEN 'New'
        WHEN 2 THEN 'Cancelled'
        WHEN 3 THEN 'Completed'
        ELSE 'Unknown'
    END AS [Status]
FROM LocalDrivingLicenseApplications LDA
INNER JOIN Applications A
    ON LDA.ApplicationID = A.ApplicationID
INNER JOIN People P
    ON A.ApplicantPersonID = P.PersonID
INNER JOIN LicenseClasses LC
    ON LDA.LicenseClassID = LC.LicenseClassID
LEFT JOIN TestAppointments TA
    ON TA.LocalDrivingLicenseApplicationID = LDA.LocalDrivingLicenseApplicationID
LEFT JOIN Tests T
    ON T.TestAppointmentID = TA.TestAppointmentID

WHERE
(
    @FilterBy = '' OR

    (@FilterBy = 'L.D.L AppID'
        AND CAST(LDA.LocalDrivingLicenseApplicationID AS NVARCHAR) LIKE '%' + @FilterValue + '%')

    OR

    (@FilterBy = 'National NO'
        AND P.NationalNo LIKE '%' + @FilterValue + '%')

    OR

    (@FilterBy = 'Full Name'
        AND (P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName)
            LIKE @FilterValue + '%' )

    OR

    (@FilterBy = 'Status'
        AND
        (
            CASE A.ApplicationStatus
                WHEN 1 THEN 'New'
                WHEN 2 THEN 'Cancelled'
                WHEN 3 THEN 'Completed'
                ELSE 'Unknown'
            END
        ) LIKE '%' + @FilterValue + '%')
)

GROUP BY
    LDA.LocalDrivingLicenseApplicationID,
    LC.ClassName,
    P.NationalNo,
    P.FirstName,
    P.SecondName,
    P.ThirdName,
    P.LastName,
    A.ApplicationDate,
    A.ApplicationStatus

ORDER BY
    LDA.LocalDrivingLicenseApplicationID DESC;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FilterBy", FilterBy);
            command.Parameters.AddWithValue("FilterValue", FilterValue);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static int generateLocalLicenseApplication(int applicationID,
         int licenseClassID)
        {
            int localDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            
                string query = @"
            INSERT INTO LocalDrivingLicenseApplications
            (
                ApplicationID,
                LicenseClassID
            )
            VALUES
            (
                @ApplicationID,
                @LicenseClassID
            );

            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
             
                    command.Parameters.AddWithValue(
                        "@ApplicationID",
                        applicationID);

                    command.Parameters.AddWithValue(
                        "@LicenseClassID",
                        licenseClassID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null &&
                            int.TryParse(result.ToString(), out int insertedID))
                        {
                            localDrivingLicenseApplicationID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        localDrivingLicenseApplicationID = -1;
                    }

            return localDrivingLicenseApplicationID;
        }
        public static bool DoesHaveActiveApplicationForLicenseClass(  int personID,int licenseClassID)
        {
            bool isFound = false;

            SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName);

            string query = @"
        SELECT 1
        FROM LocalDrivingLicenseApplications L
        INNER JOIN Applications A
            ON L.ApplicationID = A.ApplicationID
        WHERE A.ApplicantPersonID = @PersonID
          AND L.LicenseClassID = @LicenseClassID
          AND A.ApplicationStatus = 1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                isFound = result != null;
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
