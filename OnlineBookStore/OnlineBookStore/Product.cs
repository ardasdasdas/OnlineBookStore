using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
*  @author  : Eda Cam
*  @number  : 152120171037
*  @mail    : caam.edaa@gmail.com
*  @date    : 24.05.20
*  @brief   : This class is an abstract class for products. 
*/
namespace OnlineBookStore
{
    public abstract class Product
    {
        /// <summary>
        /// This functions is getters and setters.
        /// </summary>
        public string Name { get; set; }
        public string Id { get; set; }
        public string Price { get; set; }
        public byte[] Picture { get; set; }
        /// <summary>
        /// This function is abstract print properties.
        /// </summary>
        public abstract string printProperties();
    }
}
