using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI
{
    public partial class SıgnUp_UserSecondPage : Form
    {
        public SıgnUp_UserSecondPage()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
        }

        private IUserService _userService;
        Login_FirstPage loginFistPage = new Login_FirstPage();

        private void SıgnUp_UserSecondPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUpSignUpPage_Click(object sender, EventArgs e)
        {

            if (tbxPasswordSinUp.Text == tbxPasswordVerificationSinUp.Text)
            {
                _userService.Add(new User
                {
                    
                    FirstName = tbxFirstNameSignUp.Text,
                    LastName = tbxLastNameSignUp.Text,
                    Email = tbxEmailSignUp.Text,
                    Address = tbxAddresSignUp.Text,
                    UserName = tbxUserNameSignUp.Text,
                    UserPassword = tbxPasswordSinUp.Text,
                    IdentificationNumber = tbxIdentificationNumberSignUp.Text,
                    GSM = tbxGMSignUp.Text,
                    BirthDate = Convert.ToDateTime(tbxBirthDateSigUp.Text)
                });

                this.Close();
                loginFistPage.Show();

            }
           




        }


    }
}
