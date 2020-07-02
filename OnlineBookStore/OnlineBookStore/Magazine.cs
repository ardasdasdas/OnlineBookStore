using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class Magazine : Product
    {
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public string Issue { get; set; }
        public string Type { get; set; }
        public byte[] CoverPage { get; set; }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is Magazine's name.</param>
        /// <param name="_price">This parameter is Magazine's price.</param>
        public Magazine(string _name, string _price)
        {
            base.Name = _name;
            base.Price = _price;
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is Magazine's name.</param>
        /// <param name="_price">This parameter is Magazine's price.</param>
        /// <param name="_ID">This parameter is Magazine's ID.</param>
        /// <param name="_coverPage">This parameter is Magazine's cover page.</param>
        public Magazine(string _name, string _price, string _ID, byte[] _coverPage)
        {
            base.Name = _name;
            base.Price = _price;
            base.Id = _ID;
            base.Picture = _coverPage;
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is Magazine's name.</param>
        /// <param name="_id">This parameter is Magazine's ID.</param>
        /// <param name="_price">This parameter is Magazine's price.</param>
        /// <param name="_issue">This parameter is Magazine's issue.</param>
        /// <param name="_type">This parameter is Magazine's type.</param>
        /// <param name="_coverpage">This parameter is Magazine's cover page.</param>
        public Magazine(string _name, string _id, string _price, string _issue, string _type, byte[] _coverpage)
        {
            base.Name = _name;
            base.Id = _id;
            base.Price = _price;
            this.Issue = _issue;
            this.Type = _type;
            this.CoverPage = _coverpage;
        }
        /// <summary>
        /// This function shows Book's properties.
        /// </summary>
        public override string printProperties()
        {
            return "Name:" + base.Name + "Id:" + base.Id + "Price:" + base.Price + "Issue:" + this.Issue + "Type:" + this.Type;
        }
    }
}
