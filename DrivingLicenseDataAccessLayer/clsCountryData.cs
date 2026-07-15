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
    public class clsCountryData
    {

      public static DataTable GetAllCountries()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "Select * From Countries; ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
           
            }

            finally
            {
                connection.Close();
            }
            return dt;

        }
        public static string  GetNationaliyCountryNameByID(int NationalityCountryID )
        {
            string CountryName = "";
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select CountryName from Countries where CountryID=@CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", NationalityCountryID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result!=null)
                {
                    CountryName = result.ToString();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return CountryName;

        }
    }
}
