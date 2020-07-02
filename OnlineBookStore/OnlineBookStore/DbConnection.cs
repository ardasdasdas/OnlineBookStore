using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
/**
*  @author  : Eda Cam
*  @number  : 152120171037
*  @mail    : caam.edaa@gmail.com
*  @date    : 22.05.20
*  @brief   : This class was created for database connection. 
*/
namespace OnlineBookStore
{
    class DbConnection
    {
        private SqlConnection connect;
        /// <summary>
        /// This function is getter and setter.
        /// </summary>
        public SqlConnection Connect { get => connect; set => connect = value; }
        /// <summary>
        ///  Database connection function.
        /// </summary>
        public void Connection()
        {
            var connectionString = @"";//enter here the connection string after creating database
            connect = new SqlConnection(connectionString);
        }
        /// <summary>
        ///  Database open connection function.
        /// </summary>
        public void Open()
        {
            connect.Open();
        }
        /// <summary>
        ///  Database close connection function.  
        /// </summary>
        public void Close()
        {
            connect.Close();
        }
    }
}
