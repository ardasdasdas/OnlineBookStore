using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Berkay Gonenc Goksal
*  @number  : 152120171016
*  @mail    : berkaygg@hotmail.com
*  @date    : 22.05.20
*  @brief   : This class for login page. 
*/
namespace OnlineBookStore
{
    public partial class LoginForm : Form
    {
        public static MainWindow MW;
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function opens the signup form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            linkLblRegister.LinkVisited = true;
            this.Hide();
        }
        /// <summary>
        /// This function login the our store.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.CustomerList();
                List<Customer> _cuslist = db.getCustomerList();
                foreach (Customer _customer in _cuslist)
                {
                    if (_customer.IsValid(txtUsername.Text, txtPassword.Text))
                    {
                        LoginedUser.getInstance().Customer = _customer;
                        MW = new MainWindow();
                        MW.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Invalid username or password!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        /// <summary>
        /// This function exit from the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
