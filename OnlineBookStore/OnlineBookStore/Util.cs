using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
/**
*  @author  : Muzaffer Arda USLU
*  @number  : 152120171007
*  @mail    : usluarda58@gmail.com
*  @date    : 25.05.2020
*  @brief   : This class includes necessary static functions.
*/
namespace OnlineBookStore
{
    public class Util
    {
        public static List<Product> RandomThreeProductList = new List<Product>();
        public static List<Product> BookList = new List<Product>();
        public static List<Product> MusicCDList = new List<Product>();
        public static List<Product> MagazineList = new List<Product>();
        /// <summary>
        /// This function convert password to SHA256. 
        /// </summary>
        /// <param name="_customers">This parameter is password in string type.</param>
        public static string ComputeSha256Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        /// <summary>
        /// This function returns Book List which is read from database.
        /// </summary>
        /// <returns>This function returns Product List</returns>
        public static List<Product> FillBooksList()
        {
            Database db = new Database();
            db.BookList();
            return db.getBookList();
        }
        /// <summary>
        /// This function returns MusicCD List which is read from database.
        /// </summary>
        /// <returns>This function returns Product List</returns>
        public static List<Product> FillMusicCDList()
        {
            Database db = new Database();
            db.MusicCDList();
            return db.getMusicCDList();
        }
        /// <summary>
        /// This function returns Magazine List which is read from database.
        /// </summary>
        /// <returns>This function returns Product List</returns>
        public static List<Product> FillMagazineList()
        {
            Database db = new Database();
            db.MagazineList();
            return db.getMagazineList();
        }
        /// <summary>
        /// This function returns Customer List which is read from database..
        /// </summary>
        /// <returns>This function returns Customer List</returns>
        public static List<Customer> FillCustomerList()
        {
            Database db = new Database();
            db.CustomerList();
            return db.getCustomerList();
        }
        /// <summary>
        /// This function fill the UserControl Books. 
        /// </summary>
        /// <param name="BookList">This parameter is Product List.</param>
        /// <returns>This function returns User Control Books</returns>
        public static UC_Books FillUC_BooksList(List<Product> BookList)
        {
            UC_Books ucB = new UC_Books();
            foreach (Book _book in BookList)
            {
                ucB.flowLayoutBooks.Controls.Add(new UC_Book(_book));
            }
            ucB.Dock = DockStyle.Fill;
            return ucB;
        }
        /// <summary>
        /// This function fill the UserControl MusicCDs. 
        /// </summary>
        /// <param name="BoMusicCDListokList">This parameter is Product List.</param>
        /// <returns>This function returns User Control MusicCDs.</returns>
        public static UC_MusicCDs FillUC_MusicCDList(List<Product> MusicCDList)
        {
            UC_MusicCDs ucCD = new UC_MusicCDs();
            foreach (MusicCD _musidCD in MusicCDList)
            {
                ucCD.flowLayoutMusicCDs.Controls.Add(new UC_MusicCD(_musidCD));
            }
            ucCD.Dock = DockStyle.Fill;
            return ucCD;
        }
        /// <summary>
        /// This function fill the UserControl Magazines. 
        /// </summary>
        /// <param name="MagazineList">This parameter is Product List.</param>
        /// <returns>This function returns User Control Magazines.</returns>
        public static UC_Magazines FillUC_MagazineList(List<Product> MagazineList)
        {
            UC_Magazines ucM = new UC_Magazines();
            foreach (Magazine _magazine in MagazineList)
            {
                ucM.flowLayoutMagazines.Controls.Add(new UC_Magazine(_magazine));
            }
            ucM.Dock = DockStyle.Fill;
            return ucM;
        }
        /// <summary>
        /// This function convert byte to image. 
        /// </summary>
        /// <param name="inputString">This parameter is inputString in string type.</param>
        /// <returns>This function returns bitmap.</returns>
        public static Bitmap stringToImage(byte[] inputString)
        {
            byte[] imageBytes = inputString;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }
        /// <summary>
        /// This function resize an image. 
        /// </summary>
        /// <param name="bmp">This parameter is bitmap in Bitmap type.</param>
        /// <param name="width">This parameter is width.</param>
        /// <param name="height">This parameter is height.</param>
        /// <returns>This function returns bitmap.</returns>
        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }
        /// <summary>
        /// This function create welcome label according to time and logined user.
        /// </summary>
        /// <returns>This function returns string.</returns>
        public static string WelcomeLabel()
        {
            string tmpUsername = LoginedUser.getInstance().Customer.Name;
            DateTime date = DateTime.Now;
            if (date.Hour <= 12 && date.Hour >= 05)
            {
                return "Good Morning " + tmpUsername.ToUpper()
                     + " Welcome to Dream Book Store! ";
            }
            else if (date.Hour <= 18 && date.Hour >= 12)
            {
                return "Good Afternoon " + tmpUsername.ToUpper()
                     + " Welcome to Dream Book Store! ";
            }
            else if (date.Hour <= 21 && date.Hour >= 18)
            {
                return "Good  Evening " + tmpUsername.ToUpper()
                    + " Welcome to Dream Book Store! ";
            }
            else
            {
                return "Good Night " + tmpUsername.ToUpper()
                    + " Welcome to Dream Book Store! ";
            }
        }
        /// <summary>
        /// This function fill the dashboard with random three product.
        /// </summary>
        /// <returns>This function returns User Control Dashboard.</returns>
        public static UC_Dashboard FillDashboardScreen()
        {
            List<List<Product>> productList = new List<List<Product>>();
            productList.Add(Util.FillBooksList());
            productList.Add(Util.FillMusicCDList());
            productList.Add(Util.FillMagazineList());

            Random rndm = new Random();
            UC_Dashboard ucD = new UC_Dashboard();
            UC_ProductFactory UCPF = new UC_ProductFactory();

            for (int i = 0; i < productList.Count; i++)
            {
                int random = rndm.Next(productList[i].Count);
                ucD.flowLayoutEditorsChoice.Controls.Add(UCPF.CreateUC_Product
                    (productList[i][random]));
            }
            ucD.Dock = DockStyle.Fill;
            return ucD;
        }
        /// <summary>
        /// This function fill the shopping list.
        /// </summary>
        /// <returns>This function returns User Control Shopping List.</returns>
        public static UC_ShoppingList FillShoppingListScreen()
        {
            UC_ShoppingList UCItems = new UC_ShoppingList();
            foreach (ItemToPurchase item in ShoppingCart.ItemsToPurchase)
            {
                UCItems.flowLayoutShoppingList.Controls.Add(new UC_ShoppingItem(item));
            }
            UCItems.Dock = DockStyle.Fill;
            return UCItems;
        }
    }
}
