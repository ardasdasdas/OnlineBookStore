using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UC_ShoppingList : UserControl
    {
        /// <summary>
        /// This parameter is constructor.
        /// </summary>
        public UC_ShoppingList()
        {
            InitializeComponent();
            lblTOTALPAYMENT.Text = MainWindow.cart.PaymentAmount.ToString() + " $";
        }
        /// <summary>
        /// This function deletes all products from cart. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Cancel All Product Button.");
            MainWindow.cart.cancelOrder();
            flowLayoutShoppingList.Controls.Clear();
            lblTOTALPAYMENT.Text = "0 $";
        }
        /// <summary>
        /// This function creates a payment form and runs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Logger.log("Click to CheckOut Button.");
            PaymentForm PF = new PaymentForm();
            this.Hide();
            PF.Show();
        }
    }
}
