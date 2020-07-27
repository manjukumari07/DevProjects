using System;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public class LoginFormValidation
    {
        //Check whether Username and password entered is valid
        public bool ValidateLoginDetails(String UserName, String Password)
        {
            if (String.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please Enter Username and password");
                return false;
            }
            else if (UserName == "manju" && Password == "manju")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
