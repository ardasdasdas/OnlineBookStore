using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class MusicCD : Product
    {
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public string Singer { get; set; }
        public string Type { get; set; }
        public byte[] CoverPage { get; set; }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is MusicCD's name.</param>
        /// <param name="_price">This parameter is MusicCD's price.</param>
        public MusicCD(string _name, string _price)
        {
            base.Name = _name;
            base.Price = _price;
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is MusicCD's name.</param>
        /// <param name="_price">This parameter is MusicCD's price.</param>
        /// <param name="_ID">This parameter is MusicCD's ID.</param>
        /// <param name="_coverPage">This parameter is MusicCD's cover page.</param>
        public MusicCD(string _name, string _price, string _ID, byte[] _coverPage)
        {
            base.Name = _name;
            base.Price = _price;
            base.Id = _ID;
            base.Picture = _coverPage;
        }
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="_name">This parameter is MusicCD's name.</param>
        /// <param name="_id">This parameter is MusicCD's ID.</param>
        /// <param name="_price">This parameter is MusicCD's price.</param>
        /// <param name="_singer">This parameter is MusicCD's issue.</param>
        /// <param name="_type">This parameter is MusicCD's type.</param>
        /// <param name="_coverpage">This parameter is MusicCD's cover page.</param>
        public MusicCD(string _name, string _id, string _price, string _singer, string _type, byte[] _coverpage)
        {
            base.Name = _name;
            base.Id = _id;
            base.Price = _price;
            this.Singer = _singer;
            this.Type = _type;
            this.CoverPage = _coverpage;
        }
        /// <summary>
        /// This function shows Book's properties.
        /// </summary>
        public override string printProperties()
        {
            return "Name:" + base.Name + "Id:" + base.Id + "Price:" + base.Price + "Singer:" + this.Singer + "Type:" + this.Type;
        }
    }
}
