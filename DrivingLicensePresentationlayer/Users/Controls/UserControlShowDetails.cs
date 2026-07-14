using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLDPresentationLayer.Users.Controls
{
    public partial class UserControlShowDetails: UserControl
    {
        clsUserInfo _User;
        clsPerson _Person;

       
        public UserControlShowDetails()
        {
            InitializeComponent();
            
        }

        public void LoadUserData(int _UserID)
        {
            _User = clsUserInfo.Find(_UserID);
            _Person = clsPerson.Find(_User.PersonID);
            userControlPersonCard1.FillInformation(_Person);
            labelUserIDResult.Text = _User.UserID.ToString();
            labelUsernameresult.Text = _User.UserName;
            if(_User.IsActive)
            {
                labelisActiveresult.Text = "Yes";
            }
            else
            {
                labelisActiveresult.Text = "No";
            }

        }
    }
}
