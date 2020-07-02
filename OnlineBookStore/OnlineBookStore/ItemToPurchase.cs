using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class ItemToPurchase
    {
        private Product product;
        private int quantity;
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
