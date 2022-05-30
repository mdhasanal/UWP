using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicProductApp.Model
{
   public class ProductInfo
    {
        ObservableCollection<Product> product;
        public ProductInfo()
        {
            this.product = new ObservableCollection<Product>()
            {
                   new Product{Id=101,ProductName="Television",ModelNo="Sony LED-32R300E",Brand="Sony", Manufacturdate=new DateTime(2020,12,10),Feature="LED,Slim desing and 120HZ",Price=50000,Picture="Assets/Image1.jpg"},
               new Product{Id=102,ProductName="AC",ModelNo="Hitachi-Ac-E7812F",Brand="Hitachi", Manufacturdate=new DateTime(2020,10,10),Feature="Fast Cooling and Save Elecronic",Price=102000,Picture="Assets/Image4.jpg"},
               new Product{Id=103,ProductName="WashingMechin",ModelNo="WE-W87E14O",Brand="Walton", Manufacturdate=new DateTime(2021,12,10),Feature="Look Stylist,More Powerful",Price=35000,Picture="Assets/Image7.jpg"},
               new Product{Id=104,ProductName="Refregarator",ModelNo="RF-32R30G",Brand="Samsung", Manufacturdate=new DateTime(2019,12,15),Feature="Stylist,Save Electronic and More Safty",Price=55000,Picture="Assets/Image10.png"},

            };
        }
        public ObservableCollection<Product> Get()
        {
            return this.product;
        }
        public Product Get(int id)
        {
            return this.product.FirstOrDefault(t => t.Id == id);
        }
    }
}
