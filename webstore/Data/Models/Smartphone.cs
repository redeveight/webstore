using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webstore.Data.Models
{
    public class Smartphone
    {
        public int id { set; get; }

        public string modelName { set; get; }

        public string description { set; get; }

        public string shortDescription { set; get; }

        public string image { set; get; }

        public ushort price { set; get; }

        public bool isFavourite { set; get; }

        public int available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
