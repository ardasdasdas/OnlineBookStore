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
*  @brief   : This class for following logined user in the system. 
*/
namespace OnlineBookStore
{
    public class LoginedUser
    {
        private Customer customer;
        private static LoginedUser loginedUser;
        /// <summary>
        /// This function is getter and setter.
        /// </summary>
        public Customer Customer { get => customer; set => customer = value; }
        /// <summary>
        /// This function allow only one user can log in to application. This function is writed for Singleton Design Pattern.
        /// </summary>
        public static LoginedUser getInstance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }
    }
}
