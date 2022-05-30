using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductApp.Model
{
   public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ModelNo { get; set; }
        public string Brand { get; set; }
        public DateTime Manufacturdate { get; set; }
        public string Feature { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public string ManufacturDate { get => this.Manufacturdate.ToString("yyyy-MMM-dd"); }
    }

}
