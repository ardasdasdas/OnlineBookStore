using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public class Logger
    {
        /// <summary>
        /// This function saves user's every event to a txt file.
        /// </summary>
        /// <param name="btnlog">This parameter is user's event.</param>
        public static void log(string btnlog)
        {
            Customer cstmr = LoginedUser.getInstance().Customer;
            string log = cstmr.Username + "\t\t" + btnlog + " Button\t\t" + DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToLongTimeString();
            string path = Application.StartupPath + @"/Log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", "Username", "Button Info", "Date", "Time"));
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", cstmr.Username, btnlog, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", cstmr.Username, btnlog, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
            }
        }
    }
}
