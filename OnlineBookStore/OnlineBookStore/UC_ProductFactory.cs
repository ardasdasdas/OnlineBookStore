using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public class UC_ProductFactory
    {
        /// <summary>
        /// This function returns UserControl according to parameter.
        /// </summary>
        /// <param name="_product">This parameter is a product.</param>
        public UserControl CreateUC_Product(Product _product)
        {
            if (_product is Book)
            {
                return new UC_Book((Book)_product);
            }
            else if (_product is MusicCD)
            {
                return new UC_MusicCD((MusicCD)_product);
            }
            else if (_product is Magazine)
            {
                return new UC_Magazine((Magazine)_product);
            }
            else
                return null;
        }
    }
}
