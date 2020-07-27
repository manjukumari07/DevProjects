using System;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShop
{
    public partial class LoginForm : Form
    {
        private LoginFormValidation logObj = new LoginFormValidation();
        private Logger log = new Logger();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool isAuthenicate = logObj.ValidateLoginDetails(textBoxUserName.Text, textBoxPassword.Text);
            ConsignmentShop conObj = new ConsignmentShop();

            try
            {
                if (isAuthenicate)
                {
                    log.LogWrite("\n Authentication Successfull");
                    this.Hide();
                    conObj.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Username and Password");
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();
                }
            }
            catch(Exception ex)
            {
                log.LogWrite(ex.ToString());
            }
        }
    }
}