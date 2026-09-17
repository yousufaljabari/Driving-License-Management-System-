using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTest
    {
        public static int GetTestTrials(
     int LocalDrivingLicenseApplicationID,
     int TestTypeID)
        {
            return clsTestData.GetTestTrials(LocalDrivingLicenseApplicationID, TestTypeID); ;
        }
    }
}
