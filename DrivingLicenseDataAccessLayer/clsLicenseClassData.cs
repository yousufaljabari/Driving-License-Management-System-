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
    public class clsLicenseClassData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName);

            string query = @"SELECT LicenseClassID, ClassName
                     FROM LicenseClasses
                     ORDER BY LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

            
                reader.Close();
            }
            catch(Exception ex)
            {
                clsEventLogs.LogError(ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public static string GetClassName(int LicenseClassID)
        {
            string ClassName = "";

            string query = @"select ClassName from LicenseClasses where LicenseClassID=@LicenseClassID ;";
            using (SqlConnection connection=new SqlConnection(clsConnectionnSettings.connectionName))
            {
                connection.Open();
                using (SqlCommand command =new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue(
                "@LicenseClassID",
                LicenseClassID);

                    try
                    {
                       

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            ClassName = result.ToString();
                        }
                    }
                    catch(Exception ex)
                    {
                        clsEventLogs.LogError(ex);
                        ClassName = null;
                    }
                }
            }
            return ClassName;
        }
    }
}
