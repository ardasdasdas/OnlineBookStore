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
    public partial class UC_MusicCD : UserControl
    {
        string ID;
        byte[] picBox;
        /// <summary>
        /// This parameter is constructor.
        /// </summary>
        /// <param name="_musicCD">This parameter is musicCD.</param>
        public UC_MusicCD(MusicCD _musicCD)
        {
            this.Size = new Size(284, 453);
            InitializeComponent();
            lblMusicCDName.Text = _musicCD.Name;
            lblSinger.Text = _musicCD.Singer;
            lblType.Text = _musicCD.Type;
            lblMusicCDPrice.Text = _musicCD.Price;
            ID = _musicCD.Id;
            picCoverPage.Image = Util.ResizeBitmap(Util.stringToImage(_musicCD.CoverPage),
                picCoverPage.Width, picCoverPage.Height);
            picBox = _musicCD.CoverPage;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Delete from Cart " + lblMusicCDName.Text + " Book Button.");
            lblProductNumber.Text = (int.Parse(lblProductNumber.Text) + 1).ToString();
            ItemToPurchase item = new ItemToPurchase();
            item.Product = new MusicCD(lblMusicCDName.Text, lblMusicCDPrice.Text, ID, picBox);
            item.Quantity = 1;
            MainWindow.cart.addProduct(item);
        }
        /// <summary>
        /// This function adds the selected product to customer's cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtractProduct_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Delete from Cart " + lblMusicCDName.Text + " Book Button.");
            if (int.Parse(lblProductNumber.Text) > 0)
            {
                lblProductNumber.Text = (int.Parse(lblProductNumber.Text) - 1).ToString();
                ItemToPurchase item = new ItemToPurchase();
                item.Product = new MusicCD(lblMusicCDName.Text, lblMusicCDPrice.Text);
                item.Quantity = 1;
                MainWindow.cart.removeProduct(item);
            }
        }
        /// <summary>
        /// This function subtracts the selected product from customer's cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            Logger.log("Click to play music " + lblMusicCDName.Text + " Button.");
            try
            {
                string MusicPath = Application.StartupPath + "\\Musics\\" + lblSinger.Text + ".wav";
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(MusicPath))
                {
                    player.Play();
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Sorry! Demo is not exist for this album.");
                Logger.log("Exception: " + ex.Message);
            }
        }
    }
}
