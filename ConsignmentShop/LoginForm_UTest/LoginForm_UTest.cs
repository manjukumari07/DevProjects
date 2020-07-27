using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsignmentShop;
namespace LoginForm_UTest
{
    [TestFixture]
    public class LoginForm_UTest
    {
        [Test]
        public void ValidateUsernamePassword_IsTrue()
        {
            LoginFormValidation loginObj = new LoginFormValidation();
            bool result = loginObj.ValidateLoginDetails("manju", "manju");
            Assert.IsTrue(result, "Validation successfull");
        }

        [Test]
        public void ValidateUsernamePassword_Isfalse()
        {
            LoginFormValidation loginObj = new LoginFormValidation();
            bool result = loginObj.ValidateLoginDetails("kumari", "manju");
            Assert.IsFalse(result, "Validation successfull");
        }

    }
}
