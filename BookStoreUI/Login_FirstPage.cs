using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Data.SqlClient;

namespace BookStoreUI
{
    public partial class Login_FirstPage : Form
    {
        private IUserService _userService;
        private IAdminService _adminService;
        public Login_FirstPage()
        {
            InitializeComponent();
            _userService = new UserManager(new UserDal());
            _adminService = new AdminManager(new AdminDal());

        }

        private void lblSignUpLogin_Click(object sender, EventArgs e)
        {
            SıgnUp_UserSecondPage signUp_UserSecondPage = new SıgnUp_UserSecondPage();
            signUp_UserSecondPage.Show();
            this.Hide();
        }
 
        private void btnSignInLogin_Click(object sender, EventArgs e)
        {
            

            UserManager userManager = new UserManager();

            if (_adminService.IsAdmin(tbxUserNameLogin.Text, tbxPasswordLogin.Text))
            {
                AdminPace adminPace = new AdminPace();
                adminPace.Show();
                this.Hide();

            }
            
            else if (_userService.IsExist(tbxUserNameLogin.Text, tbxPasswordLogin.Text))
            {

                Library_UserThirdPace library_UserThirdPace = new Library_UserThirdPace();
                library_UserThirdPace.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("lütfen tekrar deneyiniz");
            }


        }


        private void Login_FirstPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
