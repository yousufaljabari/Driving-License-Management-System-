namespace DVLDPresentationLayer.Users
{
    public partial class frmMangeUsersScreen : Form
    {
        public frmMangeUsersScreen()
        {
            InitializeComponent();
            userControlMangeUsers1.OnRequestClose += CloseRequest;
        }

      
        private void CenterUserControl()
        {
            userControlMangeUsers1.Left =
                (this.ClientSize.Width - userControlMangeUsers1.Width) / 2;
            userControlMangeUsers1.Top =
                (this.ClientSize.Height - userControlMangeUsers1.Height) / 2;
        }
        public void CloseRequest(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMangeUsersScreen_Load(object sender, EventArgs e)
        {
            CenterUserControl();
        }

        private void frmMangeUsersScreen_Resize(object sender, EventArgs e)
        {
            CenterUserControl();
        }
    }
}
