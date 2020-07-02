using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Onur Akkepenek
*  @number  : 152120171023
*  @mail    : akkepenek38@gmail.com
*  @date    : 29.05.2020
*  @brief   : This Form is payment screen.
*/
namespace OnlineBookStore
{
    public partial class PaymentForm : Form
    {
        double TempPayment = MainWindow.cart.PaymentAmount;
        double MngCargo = 12.99;
        double PttCargo = 10.99;
        double YurticiCargo = 15.99;
        double DeliveryCost;
        double Taxex;
        public PaymentForm()
        {
            InitializeComponent();
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = LoginedUser.getInstance().Customer.Name;
                txtAddress.Text = LoginedUser.getInstance().Customer.Address;
                txtEmail.Text = LoginedUser.getInstance().Customer.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            Cargo.Visible = true;
            PrintCargoInfo();
            if (rdoCreditCard.Checked == true)
            {
                MainWindow.cart.PaymentType = "CreditCard";
                Logger.log("Click to CreditCard radio button.");
            }
            else if (rdoCash.Checked == true)
            {
                MainWindow.cart.PaymentType = "Cash";
                Logger.log("Click to Cash check box.");
            }
        }
        private void btnCargoCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoMNG.Checked == false && rdoPTT.Checked == false && rdoYURTICI.Checked == false)
                {
                    MessageBox.Show("Please choose your shipping ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cargo.Enabled = false;
                    if (rdoMNG.Checked == true)
                    {
                        Logger.log("Click to MNG Cargo Radio Button.");
                        DeliveryCost = MngCargo;
                    }
                    else if (rdoPTT.Checked == true)
                    {
                        Logger.log("Click to PTT Cargo Radio Button.");
                        DeliveryCost = PttCargo;
                    }
                    else if (rdoYURTICI.Checked == true)
                    {
                        Logger.log("Click to Yurtici Cargo Radio Button.");
                        DeliveryCost = YurticiCargo;
                    }
                    if (rdoCreditCard.Checked == true)
                    {
                        TempPayment += DeliveryCost;
                        grpCreditCard.Enabled = true;
                        PrintInstallmentInfo();
                    }
                    else if (rdoCash.Checked == true)
                    {
                        TempPayment += DeliveryCost;
                        pnlTotalPaymentScreen.Visible = true;
                        PrintSummaryPayment();
                    }
                    Logger.log("Click to Cargo Company Radio Button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Do you want to buy?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainWindow.cart.sendInvoidcebyEmail();
                Application.Exit();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Logger.log("Click to Payment Exit Button.");
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure you want to sign out?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void PrintInstallmentInfo()
        {
            lblTotalPayment1.Text = TempPayment.ToString();
            lblTotalPayment3.Text = TempPayment.ToString();
            lblTotalPayment6.Text = TempPayment.ToString();
            lblTotalPayment9.Text = TempPayment.ToString();
            lblMonthly1.Text = TempPayment.ToString();
            lblMonthly3.Text = (TempPayment / 3).ToString("N2");
            lblMonthly6.Text = (TempPayment / 6).ToString("N2");
            lblMonthly9.Text = (TempPayment / 9).ToString("N2");
        }
        public void PrintCargoInfo()
        {
            lblMNG.Visible = true;
            lblPtt.Visible = true;
            lblYurtici.Visible = true;
            lblMNG.Text = MngCargo.ToString() + "$";
            lblYurtici.Text = YurticiCargo.ToString() + "$";
            lblPtt.Text = PttCargo.ToString() + "$";
        }
        private void btnOrderSummary_Click(object sender, EventArgs e)
        {
            if (txtCardOfName.Text == "" || mtxCardNumber.Text == "    -    -    -" || mtxCVV.Text == "")
            {
                MessageBox.Show("Please enter your card details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pnlTotalPaymentScreen.Visible = true;
                rdo1nstallment.Checked = true;
                PrintSummaryPayment();
            }
        }
        private double CalculateTaxCharged()
        {
            if (TempPayment < 100)
                Taxex = TempPayment * 0.1;
            else if (TempPayment >= 100 && TempPayment < 200)
                Taxex = TempPayment * 0.2;
            else if (TempPayment >= 200 && TempPayment < 300)
                Taxex = TempPayment * 0.25;
            else if (TempPayment >= 300 && TempPayment < 500)
                Taxex = TempPayment * 0.3;
            else
                Taxex = TempPayment * 0.4;
            return Taxex;
        }
        private void PrintSummaryPayment()
        {
            lblSubtotal.Text = (MainWindow.cart.PaymentAmount - CalculateTaxCharged()).ToString() + "$";
            lblDelivery.Text = DeliveryCost.ToString() + " $";
            lblTaxes.Text = CalculateTaxCharged().ToString() + " $";
            lblCost.Text = TempPayment.ToString() + " $";
        }
        private void btnConfirmation_Click_1(object sender, EventArgs e)
        {
            Logger.log("Click to Confirmation Button.");
            try
            {
                Pdf pdf = new Pdf();
                pdf.Document(txtName.Text, mtxPhoneNumber.Text, txtAddress.Text, MainWindow.cart.PaymentType, lblSubtotal.Text, lblDelivery.Text, lblTaxes.Text, lblCost.Text);
                MainWindow.cart.sendInvoidcebyEmail();
                MessageBox.Show(MainWindow.cart.sendInvoicebySMS());
                System.Diagnostics.Process.Start("InvoicePDF.pdf");
                SaveOrder save = new SaveOrder();
                save.SaveToDatabase(lblCost.Text);
                this.Hide();
                MainWindow.cart.cancelOrder();
                LoginForm.MW.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.log("Exception " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logger.log("Click to PaymentForm Back Button.");
            this.Hide();
            LoginForm.MW.btnDashboard_Click(sender,e);
        }
    }
}
