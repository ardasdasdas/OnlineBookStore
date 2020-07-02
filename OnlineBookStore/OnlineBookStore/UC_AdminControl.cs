using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Aleyna Isikdaglilar
*  @number  : 152120171057
*  @mail    : aleynaisikdaglilar@gmail.com
*  @date    : 31.05.20
*  @brief   : This class was created for Admin Panel   
*/
namespace OnlineBookStore
{
    public partial class UC_AdminControl : UserControl
    {
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public UC_AdminControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function brings to frond User Control AdminBook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminBook_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Book Button.");
            btnAdminBook.BackColor = Color.White;
            btnAdminMagazine.BackColor = Color.LightSeaGreen;
            btnAdminMusicCD.BackColor = Color.LightSeaGreen;
            btnCustomers.BackColor = Color.LightSeaGreen;
            if (pnladminContainer.Controls["UC_AdminBook"]==null)
            {
                UC_AdminBook ucAB = new UC_AdminBook();
                ucAB.Dock = DockStyle.Fill;
                pnladminContainer.Controls.Add(ucAB);
            }
            pnladminContainer.Controls["UC_AdminBook"].BringToFront();
        }
        /// <summary>
        /// This function brings to frond User Control Magazines.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminMagazine_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Book Button.");
            btnAdminBook.BackColor = Color.LightSeaGreen;
            btnAdminMagazine.BackColor = Color.White;
            btnAdminMusicCD.BackColor = Color.LightSeaGreen;
            btnCustomers.BackColor = Color.LightSeaGreen;
            if (pnladminContainer.Controls["UC_AdminMagazine"] == null)
            {
                UC_AdminMagazine ucAM = new UC_AdminMagazine();
                ucAM.Dock = DockStyle.Fill;
                pnladminContainer.Controls.Add(ucAM);
            }
            pnladminContainer.Controls["UC_AdminMagazine"].BringToFront();
        }
        /// <summary>
        /// This function brings to frond User Control AdminMusicCD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminMusicCD_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin MusicCD Button.");
            btnAdminBook.BackColor = Color.LightSeaGreen;
            btnAdminMagazine.BackColor = Color.LightSeaGreen;
            btnAdminMusicCD.BackColor = Color.White;
            btnCustomers.BackColor = Color.LightSeaGreen;
            if (pnladminContainer.Controls["UC_AdminMusicCD"] == null)
            {
                UC_AdminMusicCD ucACD = new UC_AdminMusicCD();
                ucACD.Dock = DockStyle.Fill;
                pnladminContainer.Controls.Add(ucACD);
            }
            pnladminContainer.Controls["UC_AdminMusicCD"].BringToFront();
        }
        /// <summary>
        /// This function brings to frond User Control AdminCustomer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Customer Button.");
            btnAdminBook.BackColor = Color.LightSeaGreen;
            btnAdminMagazine.BackColor = Color.LightSeaGreen;
            btnAdminMusicCD.BackColor = Color.LightSeaGreen;
            btnCustomers.BackColor = Color.White;
            if (pnladminContainer.Controls["UC_AdminCustomer"] == null)
            {
                UC_AdminCustomer ucAC = new UC_AdminCustomer();
                ucAC.Dock = DockStyle.Fill;
                pnladminContainer.Controls.Add(ucAC);
            }
            pnladminContainer.Controls["UC_AdminCustomer"].BringToFront();
        }
    }
}
