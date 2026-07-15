using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLDataAccessLayer.ConnestionClass;
using Microsoft.Data.SqlClient;
namespace DVLDDataAccessLayer
{
    public class clsUserData
    {
        public static bool checkUserLogin(string Username, string Password)
        {
            object result = null;

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"SELECT 1 FROM Users WHERE Username = @Username AND Password = @Password And isActive = 1 ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                result = command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return (result != null);

        }

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select UserID,Users.PersonID,CONCAT_Ws(' ',People.FirstName,People.SecondName,People.ThirdName,People.LastName)'Full Name'
                     ,Username,IsActive from Users
                     inner join People on People.PersonID=Users.PersonID;";
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
                return null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool Find(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);


            string query = "Select * from Users Where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    if (reader["PersonID"] != DBNull.Value)
                        PersonID = (int)reader["PersonID"];

                    if (reader["Username"] != DBNull.Value)
                        Username = (string)reader["Username"];

                    if (reader["Password"] != DBNull.Value)
                        Password = (string)reader["Password"];

                    if (reader["isActive"] != DBNull.Value)
                        isActive = (bool)reader["isActive"];


                }
                else
                {
                    isFound = false;
                }
                reader.Close();



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetUserByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select UserID,Users.PersonID,CONCAT_Ws(' ',People.FirstName,People.SecondName,People.ThirdName,People.LastName)'Full Name'
                     ,Username,IsActive from Users
                     inner join People on People.PersonID=Users.PersonID
                      where UserID =@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
            return dt;

        }

        public static DataTable GetUserByUsername(string Username)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select UserID,Users.PersonID,CONCAT_Ws(' ',People.FirstName,People.SecondName,People.ThirdName,People.LastName)'Full Name'
                     ,Username,IsActive from Users
                     inner join People on People.PersonID=Users.PersonID
                      where Username like @Username+'%';";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
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
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
            return dt;

        }
        public static DataTable GetUserByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select UserID,Users.PersonID,CONCAT_Ws(' ',People.FirstName,People.SecondName,People.ThirdName,People.LastName)'Full Name'
                     ,Username,IsActive from Users
                     inner join People on People.PersonID=Users.PersonID
                      where Users.PersonID =@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
            return dt;

        }

        public static DataTable GetUserByFullName(string FullName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select UserID,Users.PersonID,CONCAT_Ws(' ',People.FirstName,People.SecondName,People.ThirdName,People.LastName ) as Full_Name
                     ,Username,IsActive from Users
                     inner join People on People.PersonID=Users.PersonID
                      where CONCAT_WS(' ', People.FirstName, People.SecondName, People.ThirdName, People.LastName) like @FullName + '%';";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FullName", FullName);
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
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
            return dt;

        }

        public static DataTable GetUserByisActive(bool? isActive)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select UserID,Users.PersonID,CONCAT_Ws(' ',People.FirstName,People.SecondName,People.ThirdName,People.LastName)'Full Name'
                     ,Username,IsActive from Users
                     inner join People on People.PersonID=Users.PersonID
                      where (@isActive is NULL Or Users.isActive=@isActive)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@isActive", SqlDbType.Bit).Value =
                isActive.HasValue ? isActive.Value : DBNull.Value;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);

                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
            return dt;

        }
        public static bool isPersonIDRelatedWithUser(int PersonID)
        {
            bool isRelated = false;

            SqlConnection connnection = new SqlConnection(clsConnectionnSettings.connectionName);
            string quwey = @"select 1 from Users Where Users.PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(quwey, connnection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connnection.Open();
                object result = command.ExecuteScalar();
                isRelated = (result != null);
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connnection.Close();
            }

            return isRelated;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int user_ID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);

            string query = @"
        INSERT INTO Users
        (
            PersonID,
            UserName,
            Password,
            IsActive
        )
        VALUES
        (
            @PersonID,
            @UserName,
            @Password,
            @IsActive
        );

        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    user_ID = ID;
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

            return user_ID;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool isActive)
        {

            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"UPDATE Users
                       SET 
                       Username = @Username,
                       Password = @Password,
                       isActive = @isActive
                       WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@isActive", isActive);


            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);



        }
        public static string GetPaswword(int UserID)
        {
            string Password = "";
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"Select Password from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            object? reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                if (reader != null)
                {
                    Password = Convert.ToString(reader);
                }
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return Password;
        }


      
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"DELETE FROM Users 
                         WHERE UserID = @UserID 
                         AND IsActive = 0";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static int GetUserIDByUsernameAndPassword(string Username, string Password)
        {
           
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);

            string query = @"
              SELECT UserID
              From Users
        Where Username = @Username 
          And Password = @Password
          And IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    UserID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }
        public static bool checkUserNameIsFound (string Username)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "select 1 from Users where Username=@Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = Convert.ToBoolean(result);
            }
            catch(Exception ex)
            {
                return isFound;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

       


    }
}


        
