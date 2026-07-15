using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
   public class clsCountry
    {
      public static DataTable _GetAllCoutries()
        {
            return clsCountryData.GetAllCountries();
        }
        public static string _GetNationalityCountryNameByID(int NationalityCountryID)
        {
           return clsCountryData.GetNationaliyCountryNameByID(NationalityCountryID);
        }
    }
}
