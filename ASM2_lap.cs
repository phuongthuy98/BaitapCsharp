using System;
using System.Collections.Generic;

namespace AMS2
{
    public class Product
    {
        public int id;
        public string name;
        public float price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product()
        {
            this.getInfo();
            this.Noti();
            this.AddImage();
            this.DeImage();
            
        }
        public void getInfo()
        {
            Console.WriteLine("id: "+ id);
            Console.WriteLine("name: "+name);
            Console.WriteLine("price:"+price);
            Console.WriteLine("Quality: " + qty);
            Console.WriteLine("Image: "+image);
            Console.WriteLine("Describe: "+desc);
            Console.WriteLine("Gallery: "+gallery);
        }

        public void Noti()
        {
            if (qty > 0)
            {
                Console.WriteLine("in stock");
                return;
            }
            Console.WriteLine("out of stock");
        }

        public void AddImage()
        {
            if (gallery.Count <= 10)
            {
                Console.WriteLine("Add image: ");
                string y = Console.ReadLine();
                gallery.Add(y);
                return;
            }
            Console.WriteLine("You need to delete image");
        }

        public void DeImage()
        {
            int i = 0;
            foreach (string x in gallery)
            {
                Console.WriteLine(i+"."+x);
                i++;
            }
            Console.WriteLine("Nhap anh can xoa");
            int a = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(a);
        }

        public static void Main(string[] args)
        {
            Product product = new Product();
            product.Noti();
            product.getInfo();
            product.AddImage();
            product.DeImage();
        }
            
       
        
    }
}
