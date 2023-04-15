using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineSmart.Data.Entity
{
   public class Product
    {
        internal readonly object ProductTranslations;
        internal object OrderDetails;

        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public object Carts { get; internal set; }
    }
}
