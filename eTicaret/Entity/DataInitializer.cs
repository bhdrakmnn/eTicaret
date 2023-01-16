using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaret.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kateriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                 new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
            };
            foreach (var kategori in kateriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Canon",Description="Kamera Ürünleri",Price=2500,Stock=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,image="1.jpg"},
                new Product(){Name="Asus",Description="Bilgisayar Ürünleri",Price=5000,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,image="5.jpg"},
                new Product(){Name="Lonova",Description="Bilgisayar Ürünleri",Price=7500,Stock=50,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=3,image="9.jpg"},
                new Product(){Name="Iphone 13",Description="Telefon Ürünleri",Price=2500,Stock=125,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,image="8.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}