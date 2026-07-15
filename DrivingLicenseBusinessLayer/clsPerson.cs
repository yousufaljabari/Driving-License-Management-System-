using System.Data;
using System.Runtime.CompilerServices;
using DVLDBusinessLayer;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsPerson 
    {

        

       
       
        enum enMode { Add=0,Edit=1};
        enMode Mode;
        public clsPerson()
        {
            ID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.MinValue;
            Gender = -1;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";
            Mode = enMode.Add;
        }
        public clsPerson(
        int id,
        string nationalNo,
        string firstName,
        string secondName,
        string thirdName,
        string lastName,
        DateTime dateOfBirth,
        int gender,
        string address,
        string phone,
        string email,
        int nationalityCountryID,
        string imagePath
       )
        {
            ID = id;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;
            Mode = enMode.Edit;
        }
        public int ID
        {
            set;
            get;
        }
        public string NationalNo
        {
            set;
            get;

        }

        public string FirstName
        {
            set;
            get;
        }

        public string SecondName
        {
            set;
            get;
        }

        public string ThirdName
        {
            set;
            get;
        }
        public string LastName
        {
            set;
            get;
        }
        public DateTime DateOfBirth
        {
            set;
            get;

        }
        public int Gender
        {
            set;
            get;

        }

        public string Address
        {
            set; get;

        }

        public string Phone
        {
            set; get;

        }

        public string Email
        {
            set; get;
        }

        public int NationalityCountryID
        {
            set; get;
        }

        public string ImagePath
        {
            set; get;
        }
        public static DataTable _showPersonList()
        {
           return clsPersonData.GetAllPeople();
        }
        public static DataTable _GetPersonByID(int ID )
        {
            DataTable dt = clsPersonData.GetPersonbyID(ID);
            return dt;

        }
        public static DataTable _GetPersonByNationalNo(string NationalNO)
        {
            return clsPersonData.GetPersonByNationalNo(NationalNO);
        }
        public static DataTable _GetPersonByFirstName(string FirstName)
        {
            return clsPersonData.GetPersonByFirstName(FirstName);
        }
        public static DataTable _GetPersonByLastName(string LastName)
        {
            return clsPersonData.GetPersonByLastName(LastName);
        }

        public static DataTable _GetPersonBySecondName(string SecondName)
        {
            return clsPersonData.GetPersonBySecondName(SecondName);
        }

        public static DataTable _GetPersonByThirdName(string ThirdName)
        {
            return clsPersonData.GetPersonByThirdName(ThirdName);
        }

        public static DataTable _GetPersonbyNationality(int Nationality)
        {
            return clsPersonData.GetPersonByNationality(Nationality);
        }
       

        public static DataTable _GetPersonInfoByGender(int Gender)
        {
            return clsPersonData.GetPersonByGender(Gender);
        }

        public static DataTable _GetPersonByPhone(string Phone)
        {
            return clsPersonData.GetPersonByPhone(Phone);
        }

        public static DataTable _GetPersonByEmail(string Email)
        {
            return clsPersonData.GetPersonByEmail(Email);
        }
        public static clsPerson Find(int ID)
        {

            string NationalNo = "";         
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;  
            int Gender = 0;                      
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";

            if (clsPersonData.Find(ID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,
                ref DateOfBirth,ref Gender,ref Address,ref Phone,ref Email,ref NationalityCountryID,ref ImagePath))
            {
                return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName
                   ,LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
               
        }
        public static clsPerson FindByNationalNO(string NationalNO)
        {

            int ID = 0;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            int Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";

            if (clsPersonData.FindByNationalNo(NationalNO, ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNO, FirstName, SecondName, ThirdName
                   , LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }

        private bool _addNewPerson()
        {
            this.ID= clsPersonData.addNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender,this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (ID > 0);
        }
        public static bool isPersonExist(int ID)
        {
            return clsPersonData.isPersonExist(ID);
        }
        private  bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.ID,this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,
                this.LastName,this.DateOfBirth,this.Gender,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath);
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        private void DeletePersonImage()
        {
            try
            {
              
                string imagePath = ImagePath;

                
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

               
            }
            catch (Exception ex)
            {
              
            }
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_addNewPerson())
                        {
                            Mode = enMode.Edit;
                        
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Edit:
                    {
                        return _UpdatePerson();
                    }
               

            }
            return false;

        }

    }
}
