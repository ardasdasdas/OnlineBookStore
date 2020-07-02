using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
/**
*  @author  : Eda Cam
*  @number  : 152120171037
*  @mail    : caam.edaa@gmail.com
*  @date    : 01.06.2020
*  @brief   : This class is for saving orders to the database.
*/
namespace OnlineBookStore
{
    public class SaveOrder
    {
        /// <summary>
        /// This function saves the order information in the database.
        /// </summary>
        public void SaveToDatabase(string cost)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            Database db = new Database();
            db.SaveOrder(cost);
            for (int i = 0; i < ShoppingCart.ItemsToPurchase.Count; i++)
            {
                double totalPrice = Convert.ToDouble((ShoppingCart.ItemsToPurchase[i].Product.Price), provider) * ShoppingCart.ItemsToPurchase[i].Quantity;
                string productName = ShoppingCart.ItemsToPurchase[i].Product.Name;
                int quantity = ShoppingCart.ItemsToPurchase[i].Quantity;
                string unitPrice = ShoppingCart.ItemsToPurchase[i].Product.Price+"$";
                db.SaveOrderDetail(productName, unitPrice, quantity, totalPrice.ToString()+"$");
            }
        }
    }
}
