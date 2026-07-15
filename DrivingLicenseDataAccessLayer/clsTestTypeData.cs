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
    public class clsTestTypeData
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select * from TestTypes;";
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
        public static bool UpdateTestType(int ID, string Title,string Description, decimal Fees)
        {

            int RowAffected = -1;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"UPDATE [dbo].[TestTypes]
             SET TestTypeTitle =@Title,TestTypeDescription=@Description,
             TestTypeFees = @Fees WHERE TestTypeID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
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
        public static bool GetTestTypeInfoByID(int ID, ref string Title,ref string Description, ref decimal Fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"Select * from TestTypes Where TestTypeID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    if (reader["TestTypeTitle"] != DBNull.Value)
                    {
                        Title = (string)reader["TestTypeTitle"];
                    }
                    if (reader["TestTypeDescription"] != DBNull.Value)
                    {
                        Description = (string)reader["TestTypeDescription"];
                    }
                    if (reader["TestTypeFees"] != DBNull.Value)
                    {
                        Fees = Convert.ToDecimal(reader["TestTypeFees"]);
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
            
        }

    }
}
