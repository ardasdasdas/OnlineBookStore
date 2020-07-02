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
*  @brief   : This class was created for Admin Panel Magazines Operations.   
*/
namespace OnlineBookStore
{
    public partial class UC_AdminMagazine : UserControl
    {
        byte[] _coverpage;
        public static int index_update = -1;
        public static byte[] update_image;
        string _name, _id, _price, _issue, _type;
        public static int selected_index = -1;
        Database db = new Database();
        /// <summary>
        /// This function lists magazine.
        /// </summary>
        private void btnList_Click(object sender, EventArgs e)
        {
            Logger.log("Click to List Magazine Button.");
            try
            {
                List<Product> MAList = Util.FillMagazineList();
                ListMagazines(MAList);
                dgvMagazine.Show();
                dgvMagazine.ClearSelection();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception: " + ex.Message);
            }
        }
        /// <summary>
        /// This function adds new magazine to database.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Add Magazine Button.");
            try
            {
                bool already_exists = false;
                List<Product> MAList = Util.FillMagazineList();
                for (int i = 0; i < MAList.Count; i++)
                {
                    Magazine tmp = new Magazine(_name, _id, _price, _issue, _type, _coverpage);
                    tmp = (Magazine)MAList[i];
                    if (tmp.Id == txtId.Text)
                    {
                        already_exists = true;
                        MessageBox.Show(tmp.Id + " ID already exists! Please change!");
                    }
                }
                if (already_exists == false)
                {
                    if (txtName.Text != "" && txtId.Text != "" && txtPrice.Text != "" && txtIssue.Text != "" && picCoverPage.Image != null && txtType.Text != "")
                    {
                        string name = txtName.Text;
                        string id = txtId.Text;
                        string price = txtPrice.Text;
                        string type = txtType.Text;
                        string issue = txtIssue.Text;
                        byte[] image = System.IO.File.ReadAllBytes(openFileDialogMagazine.FileName);
                        Magazine magazine = new Magazine(name, id, price, issue, type, image);
                        db.AddMagazine(magazine);
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
                Logger.log("Exception: " + ex.Message);
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
            txtIssue.Text = "";
            txtType.Text = "";
            picCoverPage.Image = null;
        }
        /// <summary>
        /// This function delete magazine in database.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Delete Magazine Button.");
            try
            {
                dgvMagazine.FirstDisplayedCell = null;
                dgvMagazine.ClearSelection();
                List<Product> MAList = Util.FillMagazineList();
                if (MAList.Count != 0)
                {
                    for (int i = 0; i < MAList.Count; i++)
                    {
                        selected_index = dgvMagazine.CurrentCell.RowIndex;

                        MemoryStream ms = new MemoryStream();
                        Bitmap img = (Bitmap)dgvMagazine.Rows[selected_index].Cells[0].Value;
                        img.Save(ms, ImageFormat.Jpeg);
                        byte[] image = ms.ToArray();

                        string name = dgvMagazine.Rows[selected_index].Cells[1].Value.ToString();
                        string price = dgvMagazine.Rows[selected_index].Cells[2].Value.ToString();
                        string id = dgvMagazine.Rows[selected_index].Cells[3].Value.ToString();
                        string issue = dgvMagazine.Rows[selected_index].Cells[4].Value.ToString();
                        string type = dgvMagazine.Rows[selected_index].Cells[5].Value.ToString();

                        Magazine magazine = new Magazine(name, id, price, issue, type, image);
                        db.DeleteMagazine(magazine);

                        if (MAList.Count != 0)
                        {
                            MAList.Clear();
                        }
                        dgvMagazine.Rows.RemoveAt(selected_index);
                        selected_index = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Magazine is Empty!");
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception: " + ex.Message);
            }
        }
        /// <summary>
        /// This function selects a row from datagridview for updating.
        /// </summary>
        private void dgvMagazine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Logger.log("Click to Data Grid View Cell Button.");
            try
            {
                List<Product> MAList = Util.FillBooksList();
                if (MAList.Count != 0)
                {
                    index_update = e.RowIndex;
                    DataGridViewRow row = dgvMagazine.Rows[index_update];
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtPrice.Text = row.Cells[2].Value.ToString();
                    txtId.Text = row.Cells[3].Value.ToString();
                    txtIssue.Text = row.Cells[4].Value.ToString();
                    txtType.Text = row.Cells[5].Value.ToString();

                    MemoryStream ms = new MemoryStream();
                    Bitmap img = (Bitmap)dgvMagazine.Rows[index_update].Cells[0].Value;
                    img.Save(ms, ImageFormat.Jpeg);

                    update_image = ms.ToArray();
                    picCoverPage.Image = Util.ResizeBitmap(Util.stringToImage(update_image), 50, 50);
                }
                else
                {
                    MessageBox.Show("Magazine is empty!");
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception: " + ex.Message);
            }
        }
        /// <summary>
        /// This function updates magazine.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Update Magazine Button.");
            try
            {
                string name = txtName.Text;
                string id = txtId.Text;
                string issue = txtIssue.Text;
                string type = txtType.Text;
                string price = txtPrice.Text;

                Magazine magazine = new Magazine(name, id, price, issue, type, update_image);
                db.UpdateMagazine(magazine);
                List<Product> MAList = Util.FillMagazineList();
                if (MAList.Count != 0)
                {
                    MAList.Clear();
                }
                ListMagazines(MAList);
                dgvMagazine.Show();
                selected_index = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception: " + ex.Message);
            }
        }
        /// <summary>
        /// This function starts to work when this form is created on runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AdminMagazine_Load(object sender, EventArgs e)
        {
            try
            {
                List<Product> MAList = Util.FillMagazineList();
                ListMagazines(MAList);
                dgvMagazine.Show();
                dgvMagazine.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public UC_AdminMagazine()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function adds magazines's image.
        /// </summary>
        private void btnPicAdd_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Picture Magazine Add Button.");
            try
            {
                openFileDialogMagazine.ShowDialog();
                picCoverPage.ImageLocation = openFileDialogMagazine.FileName;
                update_image = System.IO.File.ReadAllBytes(openFileDialogMagazine.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception: " + ex.Message);
            }
        }
        /// <summary>
        /// This function assigns datas into the datagrid for list. 
        /// </summary>
        /// <param name="_magazines">This parameter is the product list</param>
        private void ListMagazines(List<Product> _magazines)
        {
            Logger.log("Click to List Magazines Button.");
            try
            {
                dgvMagazine.Rows.Clear();
                for (int i = 0; i < _magazines.Count; i++)
                {
                    Magazine tmp = new Magazine(_name, _id, _price, _issue, _type, _coverpage);
                    tmp = (Magazine)_magazines[i];
                    dgvMagazine.Rows.Add();

                    dgvMagazine.Rows[i].Cells[0].Value = Util.ResizeBitmap(Util.stringToImage(tmp.CoverPage), 50, 50);
                    dgvMagazine.Rows[i].Cells[1].Value = tmp.Name;
                    dgvMagazine.Rows[i].Cells[2].Value = tmp.Price;
                    dgvMagazine.Rows[i].Cells[3].Value = tmp.Id;
                    dgvMagazine.Rows[i].Cells[4].Value = tmp.Issue;
                    dgvMagazine.Rows[i].Cells[5].Value = tmp.Type;
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
