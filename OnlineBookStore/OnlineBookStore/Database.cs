using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
/**
*  @author  : Eda Cam
*  @number  : 152120171037
*  @mail    : caam.edaa@gmail.com
*  @date    : 22.05.20
*  @brief   : This class was created for database operations. 
*/
namespace OnlineBookStore
{
    class Database
    {
        private DbConnection connection = new DbConnection();
        private DataTable customerTable = new DataTable();
        private DataTable bookTable = new DataTable();
        private DataTable magazineTable = new DataTable();
        private DataTable musicTable = new DataTable();
        private DataTable billTable = new DataTable();
        private DataTable billDetailTable = new DataTable();
        private Customer customer;
        private Book book;
        private Magazine magazine;
        private MusicCD music;
        private List<Product> books = new List<Product>();
        private List<Product> magazines = new List<Product>();
        private List<Product> musics = new List<Product>();
        private List<Customer> customers = new List<Customer>();
        /// <summary>
        /// This function is for pulling the customer list from the database.  
        /// </summary>
        public void CustomerList()
        {
            try
            {
                customerTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Customer", connection.Connect);
                da.Fill(customerTable);
                connection.Close();
                for (int i = 0; i < customerTable.Rows.Count; i++)
                {
                    customer = new Customer(customerTable.Rows[i]["ID"].ToString(), customerTable.Rows[i]["Name"].ToString(), customerTable.Rows[i]["Address"].ToString(), customerTable.Rows[i]["Email"].ToString(), customerTable.Rows[i]["Username"].ToString(), customerTable.Rows[i]["Password"].ToString());
                    customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for adding customers to the database.    
        /// </summary>
        /// <param name="customer">This parameter is customer that will be save to database.</param>
        public void AddCustomer(Customer customer)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_Customer(Name,Address,Email,Username,Password)values (@Name,@Address,@Email,@Username,@Password)", connection.Connect);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Username", customer.Username);
                command.Parameters.AddWithValue("@Password", customer.Password);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for updating customers to the database.     
        /// </summary>
        /// <param name="customer">This parameter is customer that will be update to database.</param>
        public void UpdateCustomer(Customer customer)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Tbl_Customer set Name=@Name,Address=@Address,Email=@Email,Username=@Username,Password=@Password where ID=@CustomerId", connection.Connect);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Username", customer.Username);
                command.Parameters.AddWithValue("@Password", customer.Password);
                command.Parameters.AddWithValue("@CustomerId", customer.CustomerID);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for pulling the book list from the database.  
        /// </summary>
        public void BookList()
        {
            try
            {
                bookTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Book", connection.Connect);
                da.Fill(bookTable);
                connection.Close();
                for (int i = 0; i < bookTable.Rows.Count; i++)
                {
                    book = new Book(bookTable.Rows[i]["Name"].ToString(), bookTable.Rows[i]["ID"].ToString(), bookTable.Rows[i]["Price"].ToString(), bookTable.Rows[i]["ISBN"].ToString(), bookTable.Rows[i]["Author"].ToString(), bookTable.Rows[i]["Publisher"].ToString(), bookTable.Rows[i]["Page"].ToString(), (byte[])bookTable.Rows[i]["CoverPage"]);
                    books.Add(book);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for adding books to the database.  
        /// </summary>
        /// <param name="book">This parameter is book that will be add to database.</param>
        public void AddBook(Book book)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_Book(ID,Name,Price,ISBN,Author,Publisher,Page,Coverpage) values(@Id,@Name,@Price,@Isbn,@Author,@Publisher,@Page,@Coverpage)", connection.Connect);
                command.Parameters.AddWithValue("@Id", book.Id);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Price", book.Price);
                command.Parameters.AddWithValue("@Isbn", book.ISBN);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Publisher", book.Publisher);
                command.Parameters.AddWithValue("@Page", book.Page);
                command.Parameters.AddWithValue("@Coverpage", book.CoverPage);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for updating books to the database.    
        /// </summary>
        /// <param name="book">This parameter is book that will be update to database.</param>
        public void UpdateBook(Book book)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Tbl_Book set Name=@Name,Price=@Price,ISBN=@Isbn,Author=@Author,Publisher=@Publisher,Page=@Page,CoverPage=@Coverpage where ID=@ProductId", connection.Connect);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Price", book.Price);
                command.Parameters.AddWithValue("@Isbn", book.ISBN);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Publisher", book.Publisher);
                command.Parameters.AddWithValue("@Page", book.Page);
                command.Parameters.AddWithValue("@Coverpage", book.CoverPage);
                command.Parameters.AddWithValue("@ProductId", book.Id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for deleting books from the database.    
        /// </summary>
        /// <param name="book">This parameter is a book that will be delete from database.</param>
        public void DeleteBook(Book book)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Tbl_Book where ID=@ProductId", connection.Connect);
                command.Parameters.AddWithValue("@ProductId", book.Id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Book deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for pulling the magazine list from the database.    
        /// </summary>
        public void MagazineList()
        {
            try
            {
                magazineTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Magazine", connection.Connect);
                da.Fill(magazineTable);
                connection.Close();
                for (int i = 0; i < magazineTable.Rows.Count; i++)
                {
                    magazine = new Magazine(magazineTable.Rows[i]["Name"].ToString(), magazineTable.Rows[i]["ID"].ToString(), magazineTable.Rows[i]["Price"].ToString(), magazineTable.Rows[i]["Issue"].ToString(), magazineTable.Rows[i]["Type"].ToString(), (byte[])magazineTable.Rows[i]["Coverpage"]);
                    magazines.Add(magazine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for adding magazines to the database.   
        /// </summary>
        /// <param name="magazine">This parameter is magazine that will be add to database.</param>
        public void AddMagazine(Magazine magazine)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_Magazine(ID,Name,Price,Issue,Type,Coverpage) values(@Id,@Name,@Price,@Issue,@Type,@Coverpage)", connection.Connect);
                command.Parameters.AddWithValue("@Id", magazine.Id);
                command.Parameters.AddWithValue("@Name", magazine.Name);
                command.Parameters.AddWithValue("@Price", magazine.Price);
                command.Parameters.AddWithValue("@Issue", magazine.Issue);
                command.Parameters.AddWithValue("@Type", magazine.Type);
                command.Parameters.AddWithValue("@Coverpage", magazine.CoverPage);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for updating magazines to the database.    
        /// </summary>
        /// <param name="magazine">This parameter is magazine that will be add to database.</param>
        public void UpdateMagazine(Magazine magazine)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Tbl_Magazine set Name=@Name,Price=@Price,Issue=@Issue,Type=@Type,CoverPage=@Coverpage where ID=@ProductId", connection.Connect);
                command.Parameters.AddWithValue("@Name", magazine.Name);
                command.Parameters.AddWithValue("@Price", magazine.Price);
                command.Parameters.AddWithValue("@Issue", magazine.Issue);
                command.Parameters.AddWithValue("@Type", magazine.Type);
                command.Parameters.AddWithValue("@Coverpage", magazine.CoverPage);
                command.Parameters.AddWithValue("@ProductId", magazine.Id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for deleting magazine from the database. 
        /// </summary>
        /// <param name="magazine">This parameter is a magazine that will be delete from database.</param>
        public void DeleteMagazine(Magazine magazine)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Tbl_Magazine where ID=@ProductId", connection.Connect);
                command.Parameters.AddWithValue("@ProductId", magazine.Id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Magazine deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for pulling the MusicCD list from the database.
        /// </summary>
        public void MusicCDList()
        {
            try
            {
                musicTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Music", connection.Connect);
                da.Fill(musicTable);
                connection.Close();
                for (int i = 0; i < musicTable.Rows.Count; i++)
                {
                    music = new MusicCD(musicTable.Rows[i]["Name"].ToString(), musicTable.Rows[i]["ID"].ToString(), musicTable.Rows[i]["Price"].ToString(), musicTable.Rows[i]["Singer"].ToString(), musicTable.Rows[i]["Type"].ToString(), (byte[])musicTable.Rows[i]["Coverpage"]);
                    musics.Add(music);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for adding MusicCD to the database.  
        /// </summary>
        /// <param name="music">This parameter is a music that will be add to database.</param>
        public void AddMusicCD(MusicCD music)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_Music(ID,Name,Price,Singer,Type,Coverpage) values(@Id,@Name,@Price,@Singer,@Type,@Coverpage)", connection.Connect);
                command.Parameters.AddWithValue("@Id", music.Id);
                command.Parameters.AddWithValue("@Name", music.Name);
                command.Parameters.AddWithValue("@Price", music.Price);
                command.Parameters.AddWithValue("@Singer", music.Singer);
                command.Parameters.AddWithValue("@Type", music.Type);
                command.Parameters.AddWithValue("@Coverpage", music.CoverPage);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for updating musicCDs to the database.   
        /// </summary>
        /// <param name="music">This parameter is a music that will be update to database.</param>
        public void UpdateMusicCD(MusicCD music)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Tbl_Music set Name=@Name,Price=@Price,Singer=@Singer,Type=@Type,CoverPage=@Coverpage where ID=@ProductId", connection.Connect);
                command.Parameters.AddWithValue("@Name", music.Name);
                command.Parameters.AddWithValue("@Price", music.Price);
                command.Parameters.AddWithValue("@Singer", music.Singer);
                command.Parameters.AddWithValue("@Type", music.Type);
                command.Parameters.AddWithValue("@Coverpage", music.CoverPage);
                command.Parameters.AddWithValue("@ProductId", music.Id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for deleting mucicCD from the database.    
        /// </summary>
        /// <param name="music">This parameter is a music that will be delete from database.</param>
        public void DeleteMusicCD(MusicCD music)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Tbl_Music where ID=@ProductId", connection.Connect);
                command.Parameters.AddWithValue("@ProductId", music.Id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("MusicCD deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for pulling the order list from the database.     
        /// </summary>
        public void OrderList()
        {
            try
            {
                billTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Date,TotalPrice,ID from Tbl_Bill where CustomerId=" + LoginedUser.getInstance().Customer.CustomerID, connection.Connect);
                da.Fill(billTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for pulling order details list from the database.    
        /// </summary>
        /// <param name="id">This parameter is bill's id.</param>
        public void OrderDetailList(int id)
        {
            try
            {
                billDetailTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select ProductName,UnitPrice,Quantity,TotalPrice from Tbl_BillProduct where BillId=" + id, connection.Connect);
                da.Fill(billDetailTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int billId;
        /// <summary>
        /// This function is for adding orders to the database.     
        /// </summary>
        /// <param name="totalPrice">This parameter is bill's Total Price.</param>
        public void SaveOrder(string totalPrice)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_Bill(CustomerId,Date,TotalPrice) values(@CustomerId,@Date,@TotalPrice)", connection.Connect);
                command.Parameters.AddWithValue("@CustomerId", int.Parse(LoginedUser.getInstance().Customer.CustomerID));
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 * FROM Tbl_Bill ORDER BY ID DESC", connection.Connect);
                billId = (int)cmd2.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is for adding orders details to the database.     
        /// </summary>
        /// <param name="productName">This parameter is Product Name that will be add to Bill.</param>
        /// <param name="unitPrice">This parameter is Unit Price that will be add to Bill.</param>
        /// <param name="quantity">This parameter is Quantity that will be add to bill.</param>
        /// <param name="totalPrice">This parameter is Total Price that will be add to bill.</param>
        public void SaveOrderDetail(string productName, string unitPrice, int quantity, string totalPrice)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Tbl_BillProduct(BillId,ProductName,UnitPrice,Quantity,TotalPrice) values(@BillId,@ProductName,@UnitPrice,@Quantity,@TotalPrice)", connection.Connect);
                command.Parameters.AddWithValue("@BillId", billId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function returns the customer list. 
        /// </summary>
        /// <returns>This function returns Customer List</returns>
        public List<Customer> getCustomerList()
        {
            return customers;
        }
        /// <summary>
        /// This function returns the book list. 
        /// </summary>
        /// <returns>This function returns Product List</returns>
        public List<Product> getBookList()
        {
            return books;
        }
        /// <summary>
        /// This function returns the magazine list.
        /// </summary>
        /// <returns>This function returns Product List</returns>
        public List<Product> getMagazineList()
        {
            return magazines;
        }
        /// <summary>
        /// This function returns the musicCD list.
        /// </summary>
        /// <returns>This function returns Product List</returns>
        public List<Product> getMusicCDList()
        {
            return musics;
        }
        /// <summary>
        /// This function returns the order list.
        /// </summary>
        /// <returns>This function returns Datatable</returns>
        public DataTable getOrderSource()
        {
            return billTable;
        }
        /// <summary>
        /// This function returns the order details list.
        /// </summary>
        /// <returns>This function returns Datatable</returns>
        public DataTable getOrderDetailSource()
        {
            return billDetailTable;
        }
    }
}
