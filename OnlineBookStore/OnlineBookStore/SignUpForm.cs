using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OnlineBookStore
{
    public partial class SignUpForm : Form
    {
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public SignUpForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function creates a Loginform. Hides this form and runs the Loginform.
        /// </summary>
        private void CreateAccount()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This function calls save customer methods to save to sql customer.
        /// </summary>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool control = false;
                bool isEmail = Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                Database db = new Database();
                db.CustomerList();
                List<Customer> _cuslist = db.getCustomerList();
                foreach (Customer _customer in _cuslist)
                {
                    if (_customer.Username == txtUsername.Text)
                    {
                        MessageBox.Show("Username is already taken. Change your username for signing.");
                        control = true;
                    }
                }
                if (control == false && isEmail == true)
                {
                    Customer newCustomer = new Customer("",
                    txtName.Text, txtAddress.Text, txtEmail.Text, txtUsername.Text, Util.ComputeSha256Hash(txtPassword.Text));
                    newCustomer.saveCustomer();
                    CreateAccount();
                }
                if (isEmail == false)
                {
                    MessageBox.Show("Your email address is not verified.");
                }
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
