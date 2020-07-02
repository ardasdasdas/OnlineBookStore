using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace OnlineBookStore
{
    public partial class UC_ShoppingItem : UserControl
    {
        string ID;
        byte[] picBox;
        Product Temp_product;
        public static bool CancelControl = false;
        public static bool TotalPaymentControl = false;
        public NumberFormatInfo provider = new NumberFormatInfo();
        /// <summary>
        /// This parameter is constructor.
        /// </summary>
        /// <param name="purchase">This parameter is purchase.</param>
        public UC_ShoppingItem(ItemToPurchase purchase)
        {
            InitializeComponent();
            try
            {
                provider.NumberDecimalSeparator = ".";
                lblName.Text = purchase.Product.Name;
                lblProductQuantitiy.Text = purchase.Quantity.ToString();
                lblUnitPrice.Text = purchase.Product.Price + " $";
                lblTotalPrice.Text = ((purchase.Quantity * double.Parse(purchase.Product.Price, provider)) + " $").ToString();
                picCoverPage.Image = Util.ResizeBitmap(Util.stringToImage(purchase.Product.Picture),
                    picCoverPage.Width, picCoverPage.Height);
                ID = purchase.Product.Id;
                picBox = purchase.Product.Picture;
                Temp_product = purchase.Product;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function adds the selected product to customer's cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Add to Cart " + lblName.Text + " Button.");
            try
            {
                provider.NumberDecimalSeparator = ".";
                lblProductQuantitiy.Text = (int.Parse(lblProductQuantitiy.Text) + 1).ToString();
                lblTotalPrice.Text = ((double.Parse(Temp_product.Price, provider) * (int.Parse(lblProductQuantitiy.Text))) + " $").ToString();
                ItemToPurchase item = new ItemToPurchase();
                item.Product = Temp_product;
                item.Quantity = 1;
                MainWindow.cart.addProduct(item);
                TotalPaymentControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function subtracts the selected product from customer's cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtractProduct_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Subtract from Cart " + lblName.Text + " Button.");
            try
            {
                if (int.Parse(lblProductQuantitiy.Text) > 0)
                {
                    lblProductQuantitiy.Text = (int.Parse(lblProductQuantitiy.Text) - 1).ToString();
                    lblTotalPrice.Text = ((double.Parse(Temp_product.Price) * (int.Parse(lblProductQuantitiy.Text))) + " $").ToString();
                    ItemToPurchase item = new ItemToPurchase();
                    item.Product = Temp_product;
                    item.Quantity = 1;
                    MainWindow.cart.removeProduct(item);
                    TotalPaymentControl = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function deletes according to product name all products from cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Cancel " + lblName.Text + " Button.");
            try
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Are you sure you want to cancel the product?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    CancelControl = true;
                    for (int i = 0; i < int.Parse(lblProductQuantitiy.Text); i++)
                    {
                        ItemToPurchase item = new ItemToPurchase();
                        item.Product = Temp_product;
                        item.Quantity = 1;
                        MainWindow.cart.removeProduct(item);
                        Util.FillShoppingListScreen();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception: " + ex.Message);
            }
        }
    }
}
