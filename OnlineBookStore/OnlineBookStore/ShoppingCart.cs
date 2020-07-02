using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Onur Akkepenek
*  @number  : 152120171023
*  @mail    : akkepenek38@gmail.com
*  @date    : 25.05.2020
*  @brief   : This class is the part that contains the data for payment transactions.  
*/
namespace OnlineBookStore
{
    public class ShoppingCart
    {
        private static List<ItemToPurchase> itemsToPurchase = new List<ItemToPurchase>();
        private string CustomerId;
        private double paymentAmount;
        private string paymentType;
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public string CustomerId1 { get => CustomerId; set => CustomerId = value; }
        public double PaymentAmount { get => paymentAmount; set => paymentAmount = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        public static List<ItemToPurchase> ItemsToPurchase { get => itemsToPurchase; set => itemsToPurchase = value; }

        public NumberFormatInfo provider = new NumberFormatInfo();
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_CustomerId">This parameter is customer's ID.</param>
        /// <param name="_paymentAmount">This parameter is payment amount.</param>
        /// <param name="_paymentType">This parameter is payment type.</param>
        /// <param name="_ItemsToPurchase">This parameter is item to purchase page.</param>
        public ShoppingCart(string _CustomerId, double _paymentAmount, string _paymentType, List<ItemToPurchase> _ItemsToPurchase)
        {
            CustomerId = _CustomerId;
            paymentAmount = _paymentAmount;
            paymentType = _paymentType;
            ItemsToPurchase = _ItemsToPurchase;
        }
        /// <summary>
        /// This function prints the products to be purchased. 
        /// </summary>
        public string printProducts()
        {
            string ProductInfo = "";
            foreach (var item in ItemsToPurchase)
            {
                ProductInfo += "Product Name :" + item.Product.Name + Environment.NewLine
                    + "Product Id :" + item.Product.Id + Environment.NewLine
                    + "Product Cost :" + item.Product.Price + Environment.NewLine
                    + "Number of products :" + item.Quantity + Environment.NewLine;
            }
            return ProductInfo;
        }
        /// <summary>
        /// This function adds the product to be purchased from the shopping site to the shopping cart.
        /// </summary>
        /// <param name="addProduct">This parameter is the product that added to shopping cart.</param>
        public void addProduct(ItemToPurchase addProduct)
        {
            try
            {
                provider.NumberDecimalSeparator = ".";
                foreach (ItemToPurchase item in ItemsToPurchase)
                {
                    if (item.Product.Name == addProduct.Product.Name)
                    {
                        paymentAmount += addProduct.Quantity * double.Parse(item.Product.Price, provider);
                        item.Quantity += addProduct.Quantity;
                        return;
                    }
                }
                ItemsToPurchase.Add(addProduct);
                paymentAmount += addProduct.Quantity * double.Parse(addProduct.Product.Price, provider);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function removes the product to be purchased from the shopping site to the shopping cart.
        /// </summary>
        /// <param name="addProduct">This parameter is the product that deleted from the shopping cart.</param>
        public void removeProduct(ItemToPurchase removeProduct)
        {
            try
            {
                provider.NumberDecimalSeparator = ".";

                foreach (ItemToPurchase item in ItemsToPurchase)
                {
                    if (item.Product.Name == removeProduct.Product.Name)
                    {
                        if (item.Quantity > removeProduct.Quantity)
                        {
                            paymentAmount -= removeProduct.Quantity * double.Parse(item.Product.Price, provider);
                            item.Quantity -= removeProduct.Quantity;
                            return;
                        }
                        else
                        {
                            paymentAmount -= item.Quantity * double.Parse(item.Product.Price, provider);
                            ItemsToPurchase.Remove(item);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function completes the ordering of the products in the shopping cart.
        /// </summary>
        public void placeOrder()
        {
            paymentAmount = 0;
            ItemsToPurchase.Clear();
        }
        /// <summary>
        /// This function deletes the product int the shopping cart.
        /// </summary>
        public void cancelOrder()
        {
            paymentAmount = 0;
            ItemsToPurchase.Clear();
        }
        /// <summary>
        /// This function sends invoice to customer.
        /// </summary>
        public void sendInvoidcebyEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dreambookstore26@gmail.com");
                mail.To.Add(LoginedUser.getInstance().Customer.Email);
                mail.Subject = "DreamBookStore Invoice";
                mail.Body = "Here is your invoice. Thank you for choosing us.";
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("dreambookstore26@gmail.com", "zrmwvjwlqdljlisu");
                SmtpServer.EnableSsl = true;
                Attachment item = new Attachment("InvoicePDF.pdf");
                mail.Attachments.Add(item);
                SmtpServer.Send(mail);
                MessageBox.Show("Your invoice has been sent to your email address.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// This function sends an invoice message to the customer's phone.
        /// </summary>
        public string sendInvoicebySMS()
        {
            return ("Message has been sent your phone number.");
        }
    }
}
