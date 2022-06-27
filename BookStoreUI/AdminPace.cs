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

namespace BookStoreUI
{
    public partial class AdminPace : Form
    {
        public AdminPace()
        {
            InitializeComponent();
            _booksService = new BooksManager(new BooksDal());
            _authorsService=new AuthorsManager(new AuthorsDal());
            _bookTypesService = new BookTypesManager(new BookTypesDal());


        }

        private IBooksService _booksService;
        private IAuthorsService _authorsService;
        private IBookTypesService _bookTypesService;



        private void AdminPace_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadAuthors();
            LoadBookTypes();

        }

        private void LoadBooks()
        {
            dgwBooksTypeAdmin.DataSource = _booksService.GetAll().ToList();
        }
        
       
        private void LoadAuthors()
        {
            cbxAuthorSearchAdmin.DataSource=_authorsService.GetAll().ToList();
            cbxAuthorSearchAdmin.DisplayMember = "AuthorName";
            cbxAuthorSearchAdmin.ValueMember = "AuthorId";

        }

        private void LoadBookTypes()
        {
           cbxBookTypeSearchAdmin.DataSource= _bookTypesService.GetAll();
            cbxBookTypeSearchAdmin.DisplayMember = "BookType";
            cbxBookTypeSearchAdmin.ValueMember = "BookTypeId";
        }

        private void dgwBooksTypeAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxBookTypeSearchAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBooksTypeAdmin.DataSource = _booksService.GetBooksByBookTypesId(Convert.ToInt32(cbxBookTypeSearchAdmin.SelectedValue));
            }
            catch 
            {

                
            }

        }

        private void cbxAuthorSearchAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBooksTypeAdmin.DataSource = _booksService.GetBooksByAuthorId(Convert.ToInt32(cbxAuthorSearchAdmin.SelectedValue));

            }
            catch 
            {

                
            }
        }

        private void tbxBookSerchAdmin_TextChanged(object sender, EventArgs e)
        {
            dgwBooksTypeAdmin.DataSource=_booksService.GetBooksByBookName(tbxBookSerchAdmin.Text);
            

        }

        private void cbxBookTypeAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               _booksService.GetBooksByBookTypesId(Convert.ToInt32(cbxBookTypeAdmin.SelectedValue));
            }
            catch
            {


            }
        }

        private void cbxAuthorAddAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
