using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
/**
*  @author  : Aleyna Isikdaglilar
*  @number  : 152120171057
*  @mail    : aleynaisikdaglilar@gmail.com
*  @date    : 28.05.20
*  @brief   : This class was created for Admin Panel Books Operations.   
*/
namespace OnlineBookStore
{
    public partial class UC_AdminBook : UserControl
    {
        byte[] _coverpage;
        string _name, _id, _price, _isbn, _author, _publisher, _page;
        public static int selected_index = -1;
        public static int index_update = -1;
        public static byte[] update_image;
        Database db = new Database();
        /// <summary>
        /// This function add new book to database. 
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Book Add Button.");
            try
            {
                bool already_exists = false;
                List<Product> BKList = Util.FillBooksList();
                for (int i = 0; i < BKList.Count; i++)
                {
                    Book tmp = new Book(_name, _id, _price, _isbn, _author, _publisher, _page, _coverpage);
                    tmp = (Book)BKList[i];
                    if (tmp.Id == txtId.Text)
                    {
                        already_exists = true;
                        MessageBox.Show(tmp.Id + " ID already exists! Please change!");
                    }
                }
                if (already_exists == false)
                {
                    if (txtName.Text != "" && txtId.Text != "" && txtAuthor.Text != "" && txtISBN.Text != "" && txtPrice.Text != "" && txtPublisher.Text != "" && picCoverPage.Image != null && txtPage.Text != "")
                    {
                        string name = txtName.Text;
                        string id = txtId.Text;
                        string price = txtPrice.Text;
                        string isbn = txtISBN.Text;
                        string author = txtAuthor.Text;
                        string publisher = txtPublisher.Text;
                        string page = txtPage.Text;
                        byte[] image = System.IO.File.ReadAllBytes(openFileDialogBook.FileName);
                        Book book = new Book(name, id, price, isbn, author, publisher, page, image);
                        db.AddBook(book);
                    }
                    else
                    {
                        MessageBox.Show("Please! Fill all fields!");
                    }
                }
                Tb_Empty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }
        /// <summary>
        /// This function delete book in database.  
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Book Delete Button.");
            try
            {
                dgvBook.FirstDisplayedCell = null;
                dgvBook.ClearSelection();
                List<Product> BKList = Util.FillBooksList();
                if (BKList.Count != 0)
                {
                    for (int i = 0; i < BKList.Count; i++)
                    {
                        selected_index = dgvBook.CurrentCell.RowIndex;

                        MemoryStream ms = new MemoryStream();
                        Bitmap img = (Bitmap)dgvBook.Rows[selected_index].Cells[0].Value;
                        img.Save(ms, ImageFormat.Jpeg);
                        byte[] image = ms.ToArray();

                        string name = dgvBook.Rows[selected_index].Cells[1].Value.ToString();
                        string price = dgvBook.Rows[selected_index].Cells[2].Value.ToString();
                        string id = dgvBook.Rows[selected_index].Cells[3].Value.ToString();
                        string isbn = dgvBook.Rows[selected_index].Cells[4].Value.ToString();
                        string author = dgvBook.Rows[selected_index].Cells[5].Value.ToString();
                        string publisher = dgvBook.Rows[selected_index].Cells[6].Value.ToString();
                        string page = dgvBook.Rows[selected_index].Cells[7].Value.ToString();

                        Book book = new Book(name, id, price, isbn, author, publisher, page, image);
                        db.DeleteBook(book);
                        if (BKList.Count != 0)
                        {
                            BKList.Clear();
                        }
                        dgvBook.Rows.RemoveAt(selected_index);
                        selected_index = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Book is Empty!");
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                Tb_Empty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }
        /// <summary>
        /// This function starts to work when this form is created on runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AdminBook_Load(object sender, EventArgs e)
        {
            try
            {
                List<Product> BKList = Util.FillBooksList();
                ListBooks(BKList);
                dgvBook.Show();
                dgvBook.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function selects a row from datagridview for updating.  
        /// </summary>
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Logger.log("Click to Data Grid View Cell");
            try
            {
                List<Product> BKList = Util.FillBooksList();
                if (BKList.Count != 0)
                {
                    index_update = e.RowIndex;
                    DataGridViewRow row = dgvBook.Rows[index_update];
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtPrice.Text = row.Cells[2].Value.ToString();
                    txtId.Text = row.Cells[3].Value.ToString();
                    txtISBN.Text = row.Cells[4].Value.ToString();
                    txtAuthor.Text = row.Cells[5].Value.ToString();
                    txtPublisher.Text = row.Cells[6].Value.ToString();
                    txtPage.Text = row.Cells[7].Value.ToString();

                    MemoryStream ms = new MemoryStream();
                    Bitmap img = (Bitmap)dgvBook.Rows[index_update].Cells[0].Value;
                    img.Save(ms, ImageFormat.Jpeg);

                    update_image = ms.ToArray();
                    picCoverPage.Image = Util.ResizeBitmap(Util.stringToImage(update_image), 50, 50);
                }
                else
                {
                    MessageBox.Show("Book is empty!");
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }
        /// <summary>
        /// This function updates book.  
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Book Update Button.");
            try
            {
                string name = txtName.Text;
                string id = txtId.Text;
                string page = txtPage.Text;
                string author = txtAuthor.Text;
                string publisher = txtPublisher.Text;
                string isbn = txtISBN.Text;
                string price = txtPrice.Text;

                Book book = new Book(name, id, price, isbn, author, publisher, page, update_image);
                db.UpdateBook(book);
                List<Product> BKList = Util.FillBooksList();
                if (BKList.Count != 0)
                {
                    BKList.Clear();
                }
                ListBooks(BKList);
                dgvBook.Show();
                selected_index = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }
        /// <summary>
        /// This function cleans textboxes. 
        /// </summary>
        private void Tb_Empty()
        {
            txtName.Text = "";
            txtId.Text = "";
            txtPrice.Text = "";
            txtISBN.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtPage.Text = "";
            picCoverPage.Image = null;
        }
        /// <summary>
        /// This function lists book.
        /// </summary>
        private void btnList_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Admin Book List Button.");
            try
            {
                List<Product> BKList = Util.FillBooksList();
                ListBooks(BKList);
                dgvBook.Show();
                dgvBook.ClearSelection();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public UC_AdminBook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function add book's image.
        /// </summary>
        private void btnPicAdd_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Picture Add Button.");
            try
            {
                openFileDialogBook.ShowDialog();
                picCoverPage.ImageLocation = openFileDialogBook.FileName;
                update_image = System.IO.File.ReadAllBytes(openFileDialogBook.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }
        /// <summary>
        /// This function assigns datas into the datagrid for list.
        /// </summary>
        /// <param name="_books">This function has a parameter the product list of book type.</param>
        private void ListBooks(List<Product> _books)
        {
            try
            {
                dgvBook.Rows.Clear();
                for (int i = 0; i < _books.Count; i++)
                {
                    Book tmp = new Book(_name, _id, _price, _isbn, _author, _publisher, _page, _coverpage);
                    tmp = (Book)_books[i];
                    dgvBook.Rows.Add();

                    dgvBook.Rows[i].Cells[0].Value = Util.ResizeBitmap(Util.stringToImage(tmp.CoverPage), 50, 50);
                    dgvBook.Rows[i].Cells[1].Value = tmp.Name;
                    dgvBook.Rows[i].Cells[2].Value = tmp.Price;
                    dgvBook.Rows[i].Cells[3].Value = tmp.Id;
                    dgvBook.Rows[i].Cells[4].Value = tmp.ISBN;
                    dgvBook.Rows[i].Cells[5].Value = tmp.Author;
                    dgvBook.Rows[i].Cells[6].Value = tmp.Publisher;
                    dgvBook.Rows[i].Cells[7].Value = tmp.Page;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
