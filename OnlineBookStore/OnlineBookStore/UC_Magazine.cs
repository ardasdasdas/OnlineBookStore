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
    public partial class UC_Magazine : UserControl
    {
        string ID;
        byte[] picBox;
        /// <summary>
        /// This parameter is constructor.
        /// </summary>
        /// <param name="_magazine">This parameter is magazine.</param>
        public UC_Magazine(Magazine _magazine)
        {
            InitializeComponent();
            lblMagazineName.Text = _magazine.Name;
            lblIssue.Text = _magazine.Issue;
            lblPrice.Text = _magazine.Price;
            lblType.Text = _magazine.Type;
            ID = _magazine.Id;
            picCoverPage.Image = Util.ResizeBitmap(Util.stringToImage(_magazine.CoverPage),
                picCoverPage.Width, picCoverPage.Height);
            picBox = _magazine.CoverPage;
        }
        /// <summary>
        /// This function adds the selected product to customer's cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Add to Cart " + lblMagazineName.Text + " Book Button.");
            lblProductNumber.Text = (int.Parse(lblProductNumber.Text) + 1).ToString();
            ItemToPurchase item = new ItemToPurchase();
            item.Product = new Magazine(lblMagazineName.Text, lblPrice.Text, ID, picBox);
            item.Quantity = 1;
            MainWindow.cart.addProduct(item);
        }
        /// <summary>
        /// This function subtracts the selected product from customer's cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtractProduct_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Delete from Cart " + lblMagazineName.Text + " Book Button.");
            if (int.Parse(lblProductNumber.Text) > 0)
            {
                lblProductNumber.Text = (int.Parse(lblProductNumber.Text) - 1).ToString();
                ItemToPurchase item = new ItemToPurchase();
                item.Product = new Magazine(lblMagazineName.Text, lblPrice.Text);
                item.Quantity = 1;
                MainWindow.cart.removeProduct(item);
            }
        }
    }
}
