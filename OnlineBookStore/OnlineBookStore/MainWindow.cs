using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class MainWindow : Form
    {
        public static ShoppingCart cart = new ShoppingCart(LoginedUser.getInstance().Customer.CustomerID,
            0, "", ShoppingCart.ItemsToPurchase);
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            timerTime.Start();
            timerWelcomeString.Start();
        }
        /// <summary>
        /// This function starts to work when this form is created on runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                lblWelcome.Text = Util.WelcomeLabel();
                btnDashboard.BackColor = Color.Teal;
                pnlContainer.Controls.Add(Util.FillDashboardScreen());
                pnlContainer.Controls.Add(Util.FillUC_BooksList(Util.FillBooksList()));
                pnlContainer.Controls.Add(Util.FillUC_MusicCDList(Util.FillMusicCDList()));
                pnlContainer.Controls.Add(Util.FillUC_MagazineList(Util.FillMagazineList()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function works every second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            if (UC_ShoppingItem.CancelControl == true)
            {
                btnMyCart_Click(sender, e);
                UC_ShoppingItem.CancelControl = false;
            }
            if (UC_ShoppingItem.TotalPaymentControl == true)
            {
                btnMyCart_Click(sender, e);
                UC_ShoppingItem.TotalPaymentControl = false;
            }
            DateTime date = DateTime.Now;
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = date.ToString("dd/MM/yyyy");
        }
        /// <summary>
        /// This function works every 250 ms and welcome label scrolling.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWelcomeString_Tick(object sender, EventArgs e)
        {
            lblWelcome.Text = lblWelcome.Text.Substring(1) + lblWelcome.Text.Substring(0, 1);
        }
        /// <summary>
        /// This functions close this form and creates Loginform and runs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Log Out button");
            MainWindow.cart.cancelOrder();
            this.Hide();
            LoginForm tempLoginForm = new LoginForm();
            tempLoginForm.Show();
        }
        /// <summary>
        /// This function brings user control dashboard to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnDashboard_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Dashboard button");
            btnDashboard.BackColor = Color.Teal;
            btnBooks.BackColor = Color.LightBlue;
            btnMusicCDs.BackColor = Color.LightBlue;
            btnMagazine.BackColor = Color.LightBlue;
            btnMyOrders.BackColor = Color.LightBlue;
            btnMyCart.BackColor = Color.LightBlue;
            btnSetting.BackColor = Color.LightBlue;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 0);
            if (pnlContainer.Controls["UC_Dashboard"] == null)
            {
                UC_Dashboard ucD = new UC_Dashboard();
                ucD.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(ucD);
            }
            pnlContainer.Controls["UC_Dashboard"].BringToFront();
        }
        /// <summary>
        /// This function brings user control books to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Books button");
            btnDashboard.BackColor = Color.LightBlue;
            btnBooks.BackColor = Color.Teal;
            btnMusicCDs.BackColor = Color.LightBlue;
            btnMagazine.BackColor = Color.LightBlue;
            btnMyOrders.BackColor = Color.LightBlue;
            btnMyCart.BackColor = Color.LightBlue;
            btnSetting.BackColor = Color.LightBlue;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 60);
            pnlContainer.Controls["UC_Books"].BringToFront();
        }
        /// <summary>
        /// This function brings user control musicCDs to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCDs_Click(object sender, EventArgs e)
        {
            Logger.log("Click to MusicCDs button");
            btnDashboard.BackColor = Color.LightBlue;
            btnBooks.BackColor = Color.LightBlue;
            btnMusicCDs.BackColor = Color.Teal;
            btnMagazine.BackColor = Color.LightBlue;
            btnMyOrders.BackColor = Color.LightBlue;
            btnMyCart.BackColor = Color.LightBlue;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 120);
            if (pnlContainer.Controls["UC_MusicCDs"] == null)
            {
                UC_MusicCDs ucCD = new UC_MusicCDs();
                ucCD.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(ucCD);
            }
            pnlContainer.Controls["UC_MusicCDs"].BringToFront();
        }
        /// <summary>
        /// This function brings user control magazines to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazine_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Magazine button");
            btnDashboard.BackColor = Color.LightBlue;
            btnBooks.BackColor = Color.LightBlue;
            btnMusicCDs.BackColor = Color.LightBlue;
            btnMagazine.BackColor = Color.Teal;
            btnMyOrders.BackColor = Color.LightBlue;
            btnMyCart.BackColor = Color.LightBlue;
            btnSetting.BackColor = Color.LightBlue;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 180);
            if (pnlContainer.Controls["UC_Magazines"] == null)
            {
                UC_Magazines ucM = new UC_Magazines();
                ucM.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(ucM);
            }
            pnlContainer.Controls["UC_Magazines"].BringToFront();
        }
        /// <summary>
        /// This function exit from the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Logger.log("Click to Main Window Exit Button.");
        }
        /// <summary>
        /// This function brings user control settings to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Settings Button.");
            btnDashboard.BackColor = Color.LightBlue;
            btnBooks.BackColor = Color.LightBlue;
            btnMusicCDs.BackColor = Color.LightBlue;
            btnMagazine.BackColor = Color.LightBlue;
            btnMyOrders.BackColor = Color.LightBlue;
            btnMyCart.BackColor = Color.LightBlue;
            btnSetting.BackColor = Color.Teal;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 360);
            if (LoginedUser.getInstance().Customer.Username == "admin")
            {
                if (pnlContainer.Controls["UC_AdminControl"] == null)
                {
                    UC_AdminControl ucAC = new UC_AdminControl();
                    ucAC.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ucAC);
                }
                pnlContainer.Controls["UC_AdminControl"].BringToFront();
            }
            else
            {
                if (pnlContainer.Controls["UC_CustomerSettings"] == null)
                {
                    UC_CustomerSettings ucCS = new UC_CustomerSettings();
                    ucCS.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ucCS);
                }
                pnlContainer.Controls["UC_CustomerSettings"].BringToFront();
            }
        }
        /// <summary>
        /// This function brings user control my orders to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            Logger.log("Click to My Orders Button.");
            btnDashboard.BackColor = Color.LightBlue;
            btnBooks.BackColor = Color.LightBlue;
            btnMusicCDs.BackColor = Color.LightBlue;
            btnMagazine.BackColor = Color.LightBlue;
            btnMyOrders.BackColor = Color.Teal;
            btnMyCart.BackColor = Color.LightBlue;
            btnSetting.BackColor = Color.LightBlue;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 240);
            if (pnlContainer.Controls["UC_MyOrders"] == null)
            {
                UC_MyOrders ucM = new UC_MyOrders();
                ucM.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(ucM);
            }
            pnlContainer.Controls["UC_MyOrders"].BringToFront();
        }
        /// <summary>
        /// This function brings user control my cart to front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyCart_Click(object sender, EventArgs e)
        {
            Logger.log("Click to My Cart Button.");
            btnDashboard.BackColor = Color.LightBlue;
            btnBooks.BackColor = Color.LightBlue;
            btnMusicCDs.BackColor = Color.LightBlue;
            btnMagazine.BackColor = Color.LightBlue;
            btnMyOrders.BackColor = Color.LightBlue;
            btnMyCart.BackColor = Color.Teal;
            btnSetting.BackColor = Color.LightBlue;
            pnlSelectedButton.Visible = true;
            pnlSelectedButton.Location = new Point(0, 300);
            if (pnlContainer.Controls["UC_ShoppingList"] == null)
            {
                pnlContainer.Controls.Add(Util.FillShoppingListScreen());
            }
            else
            {
                pnlContainer.Controls.RemoveByKey("UC_ShoppingList");
                pnlContainer.Controls.Add(Util.FillShoppingListScreen());
            }
            pnlContainer.Controls["UC_ShoppingList"].BringToFront();
        }
    }
}
