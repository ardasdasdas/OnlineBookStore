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
*  @brief   : This class was created for Admin Panel MusicCDs Operations.   
*/
namespace OnlineBookStore
{
    public partial class UC_AdminMusicCD : UserControl
    {
        string _name, _id, _price, _singer, _type;
        byte[] _coverpage;
        public static int selected_index = -1;
        public static int index_update = -1;
        public static byte[] update_image;
        Database db = new Database();
        /// <summary>
        /// This function add new music to database.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool already_exists = false;
                List<Product> MUList = Util.FillMusicCDList();
                for (int i = 0; i < MUList.Count; i++)
                {
                    MusicCD tmp = new MusicCD(_name, _id, _price, _singer, _type, _coverpage);
                    tmp = (MusicCD)MUList[i];
                    if (tmp.Id == txtId.Text)
                    {
                        already_exists = true;
                        MessageBox.Show(tmp.Id + " ID already exists! Please change!");
                    }
                }
                if (already_exists == false)
                {
                    if (txtName.Text != "" && txtId.Text != "" && txtPrice.Text != "" && txtSinger.Text != "" && picCoverPage.Image != null && txtType.Text != "")
                    {
                        string name = txtName.Text;
                        string id = txtId.Text;
                        string price = txtPrice.Text;
                        string type = txtType.Text;
                        string singer = txtSinger.Text;
                        byte[] image = System.IO.File.ReadAllBytes(openFileDialogMusicCDs.FileName);
                        MusicCD music = new MusicCD(name, id, price, singer, type, image);
                        db.AddMusicCD(music);
                    }
                    else
                    {
                        MessageBox.Show("Please! Fill all fields!");
                    }
                }
                Tb_Empty();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            txtSinger.Text = "";
            txtType.Text = "";
            picCoverPage.Image = null;
        }
        /// <summary>
        /// This function deletes music in database. 
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMusicCDs.FirstDisplayedCell = null;
                dgvMusicCDs.ClearSelection();
                List<Product> MUList = Util.FillMusicCDList();
                if (MUList.Count != 0)
                {
                    for (int i = 0; i < MUList.Count; i++)
                    {
                        selected_index = dgvMusicCDs.CurrentCell.RowIndex;

                        MemoryStream ms = new MemoryStream();
                        Bitmap img = (Bitmap)dgvMusicCDs.Rows[selected_index].Cells[0].Value;
                        img.Save(ms, ImageFormat.Jpeg);
                        byte[] image = ms.ToArray();

                        string name = dgvMusicCDs.Rows[selected_index].Cells[1].Value.ToString();
                        string price = dgvMusicCDs.Rows[selected_index].Cells[2].Value.ToString();
                        string id = dgvMusicCDs.Rows[selected_index].Cells[3].Value.ToString();
                        string singer = dgvMusicCDs.Rows[selected_index].Cells[4].Value.ToString();
                        string type = dgvMusicCDs.Rows[selected_index].Cells[5].Value.ToString();

                        MusicCD musicCD = new MusicCD(name, id, price, singer, type, image);

                        db.DeleteMusicCD(musicCD);
                        if (MUList.Count != 0)
                        {
                            MUList.Clear();
                        }
                        dgvMusicCDs.Rows.RemoveAt(selected_index);
                        selected_index = -1;
                    }
                }
                else
                {
                    MessageBox.Show("MusicCD is Empty!");
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function starts to work when this form is created on runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AdminMusicCD_Load(object sender, EventArgs e)
        {
            try
            {
                List<Product> MUList = Util.FillMusicCDList();
                ListMusicCDs(MUList);
                dgvMusicCDs.Show();
                dgvMusicCDs.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function selects a row from datagridview for updating.
        /// </summary>
        private void dgvMusicCDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Logger.log("Click to Data Grid View Cell Button.");
            try
            {
                List<Product> MCDList = Util.FillMusicCDList();
                if (MCDList.Count != 0)
                {
                    index_update = e.RowIndex;
                    DataGridViewRow row = dgvMusicCDs.Rows[index_update];
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtPrice.Text = row.Cells[2].Value.ToString();
                    txtId.Text = row.Cells[3].Value.ToString();
                    txtSinger.Text = row.Cells[4].Value.ToString();
                    txtType.Text = row.Cells[5].Value.ToString();

                    MemoryStream ms = new MemoryStream();
                    Bitmap img = (Bitmap)dgvMusicCDs.Rows[index_update].Cells[0].Value;
                    img.Save(ms, ImageFormat.Jpeg);

                    update_image = ms.ToArray();
                    picCoverPage.Image = Util.ResizeBitmap(Util.stringToImage(update_image), 50, 50);
                }
                else
                {
                    MessageBox.Show("MusicCD is empty!");
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function updates music.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string id = txtId.Text;
                string singer = txtSinger.Text;
                string type = txtType.Text;
                string price = txtPrice.Text;

                MusicCD musicCD = new MusicCD(name, id, price, singer, type, update_image);
                db.UpdateMusicCD(musicCD);
                List<Product> MCD = Util.FillMusicCDList();
                if (MCD.Count != 0)
                {
                    MCD.Clear();
                }
                ListMusicCDs(MCD);
                dgvMusicCDs.Show();
                selected_index = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function lists Music.
        /// </summary>
        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> MUList = Util.FillMusicCDList();
                ListMusicCDs(MUList);
                dgvMusicCDs.Show();
                dgvMusicCDs.ClearSelection();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        public UC_AdminMusicCD()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function add music's image.
        /// </summary>
        private void btnPicAdd_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMusicCDs.ShowDialog();
                picCoverPage.ImageLocation = openFileDialogMusicCDs.FileName;
                update_image = System.IO.File.ReadAllBytes(openFileDialogMusicCDs.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function assigns datas into the datagrid for list. .
        /// </summary>
        /// <param name="_musicCDs">This parameter is product list.</param>
        private void ListMusicCDs(List<Product> _musicCDs)
        {
            try
            {
                dgvMusicCDs.Rows.Clear();
                for (int i = 0; i < _musicCDs.Count; i++)
                {
                    MusicCD tmp = new MusicCD(_name, _id, _price, _singer, _type, _coverpage);
                    tmp = (MusicCD)_musicCDs[i];
                    dgvMusicCDs.Rows.Add();

                    dgvMusicCDs.Rows[i].Cells[0].Value = Util.ResizeBitmap(Util.stringToImage(tmp.CoverPage), 50, 50);
                    dgvMusicCDs.Rows[i].Cells[1].Value = tmp.Name;
                    dgvMusicCDs.Rows[i].Cells[2].Value = tmp.Price;
                    dgvMusicCDs.Rows[i].Cells[3].Value = tmp.Id;
                    dgvMusicCDs.Rows[i].Cells[4].Value = tmp.Singer;
                    dgvMusicCDs.Rows[i].Cells[5].Value = tmp.Type;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
