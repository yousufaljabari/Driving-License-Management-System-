using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLicenseClass
    {
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

        public static string GetClassName(int LicenseClassID)
        {
            return clsLicenseClassData.GetClassName(LicenseClassID)
;        }
    }
}
