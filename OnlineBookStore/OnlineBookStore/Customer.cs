using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
*  @author  : Berkay Gonenc Goksal
*  @number  : 152120171016
*  @mail    : berkaygg@hotmail.com
*  @date    : 22.05.20
*  @brief   : This class for customers' informations. 
*/
namespace OnlineBookStore
{
    public class Customer
    {
        private string customerID;
        private string name;
        private string address;
        private string email;
        private string username;
        private string password;
        public static int id = 1;
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="customerID">This parameter is Customer's ID.</param>
        /// <param name="name">This parameter is Customer's name.</param>
        /// <param name="address">This parameter is Customer's address.</param>
        /// <param name="email">This parameter is Customer's ISBN email.</param>
        /// <param name="username">This parameter is Customer's username.</param>
        /// <param name="password">This parameter is Customer's password.</param>
        public Customer(string customerID, string name, string address, string email, string username, string password)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public string CustomerID { get => customerID; set => customerID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        /// <summary>
        /// This function shows Book's properties.
        /// </summary>
        public string printCustomerDetails()
        {
            return "CustomerID:" + CustomerID + " " + "Name:" + Name + " " + "Address:" + Address + " " +
                "Email:" + Email + " " + "Username" + Username + " " + "Password:" + Password;
        }
        /// <summary>
        /// This function checks user's username and password from database.
        /// </summary>
        /// <param name="Username">This parameter is Customer's username that is entered by customer.</param>
        /// <param name="Password">This parameter is Customer's password that is entered bt customer.</param>
        /// <returns>If username and password that are parameters matches in database returns true, else return false.</returns>
        public bool IsValid(string Username, string Password)
        {
            return this.Username.Equals(Username) && this.Password.Equals(Util.ComputeSha256Hash(Password));
        }
        public void saveCustomer()
        {
            Database db = new Database();
            db.AddCustomer(this);
        }
    }
}
