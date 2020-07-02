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
*  @brief   : This class for books' informations. 
*/
namespace OnlineBookStore
{
    public class Book : Product
    {
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Page { get; set; }
        public byte[] CoverPage { get; set; }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is Book's name.</param>
        /// <param name="_price">This parameter is Book's price.</param>
        /// <param name="_ID">This parameter is Book's ID.</param>
        /// <param name="_coverPage">This parameter is Book's cover page.</param>
        public Book(string _name, string _price, string _ID, byte[] _coverPage)
        {
            base.Name = _name;
            base.Price = _price;
            base.Id = _ID;
            base.Picture = _coverPage;
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is Book's name.</param>
        /// <param name="_id">This parameter is Book's ID.</param>
        /// <param name="_price">This parameter is Book's price.</param>
        /// <param name="_isbn">This parameter is Book's ISBN number.</param>
        /// <param name="_author">This parameter is Book's author.</param>
        /// <param name="_publisher">This parameter is Book's publisher.</param>
        /// <param name="_page">This parameter is Books's page number.</param>
        /// <param name="_coverpage">This parameter is Book's cover page.</param>
        public Book(string _name, string _id, string _price, string _isbn, string _author, string _publisher, string _page, byte[] _coverpage)
        {
            base.Name = _name;
            base.Id = _id;
            base.Price = _price;
            this.ISBN = _isbn;
            this.Author = _author;
            this.Publisher = _publisher;
            this.Page = _page;
            this.CoverPage = _coverpage;
        }
        /// <summary>
        /// This function shows Book's properties.
        /// </summary>
        public override string printProperties()
        {
            return "Name:" + base.Name + " Id:" + base.Id + " Price:" + base.Price + " ISBN:" + this.ISBN + " Author:" + this.Author + " Publisher" + this.Publisher + " Page:" + this.Page;
        }
    }
}
