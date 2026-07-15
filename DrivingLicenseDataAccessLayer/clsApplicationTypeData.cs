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
    public class clsApplicationTypeData
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select * from ApplicationTypes;";
            SqlCommand command = new SqlCommand(query, connection);
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
        public static bool UpdateApplicationType(int ID, string Title, decimal Fees)
        {

            int RowAffected = -1;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"UPDATE [dbo].[ApplicationTypes]
             SET ApplicationTypeTitle =@Title,
             ApplicationFees = @Fees WHERE ApplicationTypeID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (RowAffected > 0);
        }
        public static bool GetApplicationTypeInfoByID(int ID,ref string Title ,ref decimal Fees )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"Select * from ApplicationTypes Where ApplicationTypeID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    if (reader["ApplicationTypeTitle"]!=DBNull.Value)
                    {
                        Title = (string)reader["ApplicationTypeTitle"];
                    }
                    if (reader["ApplicationFees"] != DBNull.Value)
                    {
                        Fees = Convert.ToDecimal(reader["ApplicationFees"]);
                    }

                }
                else
                {
                    isFound = false;
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
            return isFound;
;        }

        public static decimal GetApplicationFees(int applicationTypeID)
        {
            decimal fees = -1;

            SqlConnection connection =
                new SqlConnection(clsConnectionnSettings.connectionName);

            string query = @"
             SELECT ApplicationFees
             FROM ApplicationTypes
             WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    fees = Convert.ToDecimal(result);
                }

            }
            catch
            {
                fees = -1;
            }
            finally
            {
                connection.Close();
            }

            return fees;
        }
    }
}

