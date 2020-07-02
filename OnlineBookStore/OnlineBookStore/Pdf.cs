using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using OnlineBookStore.Properties;
using System.Globalization;
/**
*  @author  : Onur Akkepenek
*  @number  : 152120171023
*  @mail    : akkepenek38@gmail.com
*  @date    : 29.05.2020
*  @brief   : This class is prints the invoice in pdf.
*/
namespace OnlineBookStore
{
    class Pdf
    {
        /// <summary>
        /// This function prints the invoice in pdf.
        /// </summary>
        /// <param name="_name">This parameter is customer's name.</param>
        /// <param name="_phoneNumber">This parameter is customer's phone number.</param>
        /// <param name="_adress">This parameter is customer's addres.</param>
        /// <param name="_paymentType">This parameter is Customer's payment type.</param>
        /// <param name="_delivery">This parameter is shipping cost.</param>
        /// <param name="_taxex">This parameter is tax.</param>
        /// <param name="_totalCost">This parameter is the total cost.</param>
        public void Document(string _name, string _phoneNumber, string _adress, string _paymentType, string _subtotal, string _delivery, string _taxex, string _totalCost)
        {
            try
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 40f, 40f, 80f, 80f);
                PdfWriter.GetInstance(pdfDoc, new FileStream("InvoicePDF.pdf", FileMode.Create));
                pdfDoc.Open();
                pdfDoc.AddCreator("Dream Book Store");
                pdfDoc.AddCreationDate();
                pdfDoc.AddAuthor("Admin");
                pdfDoc.AddHeader("Dream Book Store", "Involce");
                pdfDoc.AddTitle("Dream Book Store");
                Paragraph spacer = new Paragraph("")
                {
                    SpacingBefore = 30f,
                    SpacingAfter = 30f
                };
                string[] headers = new string[5];
                headers[0] = "ID";
                headers[1] = "Product Name";
                headers[2] = "Quantity";
                headers[3] = "Price";
                headers[4] = "Total Price";
                var logo = iTextSharp.text.Image.GetInstance(Resources.invoice, Resources.invoice.RawFormat);
                logo.ScalePercent(21f);
                logo.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top - 30);
                pdfDoc.Add(logo);
                var timeTable = new PdfPTable(new[] { .75f })
                {
                    HorizontalAlignment = 2,
                    WidthPercentage = 40,
                    DefaultCell = { MinimumHeight = 12f, }
                };
                timeTable.AddCell("Date");
                timeTable.AddCell(DateTime.Now.ToString());
                pdfDoc.Add(timeTable);
                pdfDoc.Add(spacer);
                Paragraph elements1 = new Paragraph("Bill to :" +
                    Environment.NewLine + "Dream Book Store" +
                    Environment.NewLine + "Root" +
                    Environment.NewLine + "Eskisehir Osmangazi University " +
                    Environment.NewLine + "Computer Engineering Department " +
                    Environment.NewLine + "0222 222 01 01" +
                    Environment.NewLine + "DreamBookStore26@gmail.com" +
                    Environment.NewLine);
                Paragraph elements2 = new Paragraph("Ship to :" +
                    Environment.NewLine + "Customer ID: " + MainWindow.cart.CustomerId1 +
                    Environment.NewLine + _name +
                    Environment.NewLine + _adress +
                    Environment.NewLine + _phoneNumber +
                    Environment.NewLine + _paymentType);
                elements1.Alignment = Element.ALIGN_LEFT;
                elements2.Alignment = Element.ALIGN_RIGHT;
                pdfDoc.Add(elements1);
                pdfDoc.Add(elements2);
                pdfDoc.Add(spacer);
                PdfPTable table = new PdfPTable(new[] { .75f, 2.5f, 1f, 1f, 1.5f })
                {
                    HorizontalAlignment = 1,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f, }
                };
                for (int i = 0; i < headers.Length; i++)
                {
                    PdfPCell cell = new PdfPCell(new PdfPCell());
                    cell.AddElement(new Chunk(headers[i]));
                    table.AddCell(cell);
                }
                for (int i = 0; i < ShoppingCart.ItemsToPurchase.Count; i++)
                {
                    double TotalPrice = Convert.ToDouble((ShoppingCart.ItemsToPurchase[i].Product.Price), provider) * ShoppingCart.ItemsToPurchase[i].Quantity;
                    table.AddCell(ShoppingCart.ItemsToPurchase[i].Product.Id);
                    table.AddCell(ShoppingCart.ItemsToPurchase[i].Product.Name);
                    table.AddCell(ShoppingCart.ItemsToPurchase[i].Quantity.ToString());
                    table.AddCell(ShoppingCart.ItemsToPurchase[i].Product.Price);
                    table.AddCell(TotalPrice.ToString());
                }
                pdfDoc.Add(table);
                Paragraph elements3 = new Paragraph("Subtotal :" + _subtotal +
                    Environment.NewLine + "Delivery :" + _delivery +
                    Environment.NewLine + "Taxex :" + _taxex +
                    Environment.NewLine + "-----------------------" +
                    Environment.NewLine + "Total Cost =" + _totalCost);
                elements3.Alignment = Element.ALIGN_RIGHT;
                pdfDoc.Add(elements3);
                pdfDoc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
