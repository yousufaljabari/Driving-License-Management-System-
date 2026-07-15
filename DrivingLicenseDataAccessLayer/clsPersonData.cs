using System.Data;
using System.Security.Cryptography.X509Certificates;
using DVDLDataAccessLayer.ConnestionClass;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
namespace DVLDDataAccessLayer
{
    public class clsPersonData

    {

        public static int addNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string lastName, DateTime DateOfBirth, int Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int person_ID = -1;
            SqlConnection connnection = new SqlConnection(clsConnectionnSettings.connectionName);
            string querey = @"INSERT INTO People
                     (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
                     VALUES
                     (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                      Select Scope_Identity()";
            SqlCommand command = new SqlCommand(querey, connnection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }


            try
            {
                connnection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    person_ID = ID;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connnection.Close();
            }
            return person_ID;
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "select * from People;";

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
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetPersonbyID(int ID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "select * from People where PersonID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }



                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetPersonByNationalNo(string NattionalNo)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "select * from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NattionalNo);
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

        public static DataTable GetPersonByFirstName(string FirstName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "SELECT * FROM People WHERE FirstName LIKE  @FirstName + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
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
        public static DataTable GetPersonByLastName(string LastName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "SELECT * FROM People WHERE LastName LIKE  @LastName + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LastName", LastName);
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



        public static DataTable GetPersonBySecondName(string SecondName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "SELECT * FROM People WHERE SecondName LIKE  @SecondName + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SecondName", SecondName);
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


        public static DataTable GetPersonByThirdName(string ThirdName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "SELECT * FROM People WHERE ThirdName LIKE  @ThirdName + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
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
        public static DataTable GetPersonByNationality(int Nationality)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"SELECT People.* FROM People
          INNER JOIN Countries
           ON People.NationalityCountryID = Countries.CountryID
           where People.NationalityCountryID =@Nationality";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nationality", Nationality);
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



        public static DataTable GetPersonByGender(int Gender)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "Select * from People Where Gender = @Gender";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Gender", Gender);

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
                Console.WriteLine("Error : " + ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetPersonByPhone(string Phone)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "SELECT * FROM People WHERE Phone LIKE  @Phone + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone", Phone);
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

        public static DataTable GetPersonByEmail(string Email)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = "SELECT * FROM People WHERE Email LIKE  @Email + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);
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

        public static bool Find(int ID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string lastName, ref DateTime DateOfBirth, ref int Gender,
            ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);


            string query = "Select * from People Where PersonID=@ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    if (reader["NationalNo"] != DBNull.Value)
                        NationalNo = (string)reader["NationalNo"];

                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];

                    if (reader["SecondName"] != DBNull.Value)
                        SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];

                    if (reader["LastName"] != DBNull.Value)
                        lastName = (string)reader["LastName"];

                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["Gender"] != DBNull.Value)
                        Gender = Convert.ToInt32(reader["Gender"]);

                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];

                    if (reader["Phone"] != DBNull.Value)
                        Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    if (reader["NationalityCountryID"] != DBNull.Value)
                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath =(string )reader["ImagePath"];



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
        public static bool FindByNationalNo( string NationalNo,ref int ID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string lastName, ref DateTime DateOfBirth, ref int Gender,
            ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);


            string query = "Select * from People Where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    if (reader["PersonID"] != DBNull.Value)
                        ID = (int)reader["PersonID"];

                    if (reader["FirstName"] != DBNull.Value)
                        FirstName = (string)reader["FirstName"];

                    if (reader["SecondName"] != DBNull.Value)
                        SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];

                    if (reader["LastName"] != DBNull.Value)
                        lastName = (string)reader["LastName"];

                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["Gender"] != DBNull.Value)
                        Gender = Convert.ToInt32(reader["Gender"]);

                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];

                    if (reader["Phone"] != DBNull.Value)
                        Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    if (reader["NationalityCountryID"] != DBNull.Value)
                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = Convert.ToString(reader["ImagePath"]);



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

        public static bool UpdatePerson(int ID,string NationalNo, string FirstName, string SecondName, string ThirdName, string lastName, DateTime DateOfBirth, int Gender,
            string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"UPDATE People
                       SET 
                       NationalNo = @NationalNo,
                       FirstName = @FirstName,
                       SecondName = @SecondName,
                       ThirdName = @ThirdName,
                       LastName = @LastName,
                       DateOfBirth = @DateOfBirth,
                       Gender = @Gender,
                       Address = @Address,
                       Phone = @Phone,
                       Email = @Email,
                       NationalityCountryID = @NationalityCountryID,
                       ImagePath = @ImagePath
                       WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName" , FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName ",ThirdName);
            command.Parameters.AddWithValue("@LastName" , lastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender",Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID ", NationalityCountryID);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

           

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

        public static bool DeletePerson (int PersonID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"DELETE FROM People WHERE PersonID =@PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            finally
            {
                connection.Close();
            }
            return (RowAffected > 0);
        }

        public static bool isPersonExist(int PersonID)
        {
            bool HasRows = false;
            SqlConnection connection = new SqlConnection(clsConnectionnSettings.connectionName);
            string query = @"select Found=1 from People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                HasRows = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                HasRows = false;
            }
            finally
            {
                connection.Close();
            }

            return HasRows;

        }
    }
}
