using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAEntity240822G
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToList_Click(object sender, EventArgs e)
        {
            //Categori tablosuna datagridview a yazdıralım.
            dgwList.DataSource = db.Categories.ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Customer CompanyName, ContactName, Phone ve Adres bilgilerini getiriniz.

            dgwList.DataSource = db.Customers.Select(c => new
            {
                Sirket = c.CompanyName,
                Yetkili = c.ContactName,
                Telefon = c.Phone,
                Adres = c.Address
            }).ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            dgwList.DataSource = db.Products.Where(a => a.UnitsInStock > 100 && a.UnitsInStock < 200).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            //dgwList.DataSource = db.Products.OrderBy(a => a.ProductName).ToList();
            dgwList.DataSource = db.Products.Select(a => new
            {
                a.ProductID,
                a.ProductName,
                a.UnitsInStock,
                a.UnitPrice
            }).OrderByDescending(a => a.UnitsInStock).ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            //Hangi kategoride kaç tane ürün var ?
            dgwList.DataSource = db.Products.GroupBy(a => a.Category.CategoryName).Select(b => new
            {
                KategoriAdi = b.Key,
                Toplam_Stok_Miktari = b.Sum(c => c.UnitsInStock)
            }).ToList();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Kategori tablosundaki ilk veriyi geitriniz ve mesaj olarak bastırınız.

            try
            {
                Category ct = db.Categories.Where(a => a.CategoryID > 50).First();
                MessageBox.Show("50 ID'sine ait olan kategori " + ct.CategoryName);

            }
            catch (Exception)
            {

                MessageBox.Show("Kategori Bulunamadı.");
            }

        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Category ct = db.Categories.Where(a => a.CategoryID > 50).FirstOrDefault();

            if (ct == null)
            {
                MessageBox.Show("Aradığınız kategori bulunamadı.");
            }
            else
                MessageBox.Show("İlk gelen kategorinin adı: " + ct.CategoryName);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Employeelerden ıd si 1 olanı bulunuz, null dönüyorsa mesaj yazdırınız, dönmüyorsa adı ve soyadını yazdırınız.
            Employee emp = db.Employees.Find(1);
            if (emp != null)
            {
                MessageBox.Show("Adı: " + emp.FirstName + "\nSoyadı: " + emp.LastName);
            }
            else
                MessageBox.Show("ID'si 1 olan çalışan bulunamadı.");

        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            //product tabosundaki ürünleri UnitPrice a göre çoktn aza sıralayınız. İlk 5 ürünün ID, ProductName, UnitPrice, UnitsInStock bilgilerini getiriniz.
            var result = db.Products.OrderByDescending(f => f.UnitPrice).Take(5).Select(x => new
            {
                ID = x.ProductID,
                Name = x.ProductName,
                Price = x.UnitPrice,
                Stok = x.UnitsInStock
            }).ToList();

            dgwList.DataSource = result.ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            //Stokta en çok bulunan ürünlerimden 10 ile 20 arasındakileri listeleyiniz.

            //dgwList.DataSource = db.Products.OrderByDescending(a => a.UnitsInStock).Take(20).Skip(10).Select(a => new
            //{
            //    ID = a.ProductID,
            //    Name = a.ProductName,
            //    UnitPrice = a.UnitPrice,
            //    Stock = a.UnitsInStock
            //}).ToList();

            dgwList.DataSource = db.Products.OrderByDescending(a => a.UnitsInStock).Select(a => new
            {
                ID = a.ProductID,
                Name = a.ProductName,
                UnitPrice = a.UnitPrice,
                Stock = a.UnitsInStock
            }).Take(20).Skip(10).ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Çalışanların isimleri içerisinde a harfi geçenleri listeleyelim ve 5 ile 10 arasındakileri alalım.

            dgwList.DataSource = db.Employees.Where(a => a.FirstName.Contains("a")).OrderBy(z => z.FirstName).Skip(5).Take(5).ToList();

        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            //Category tablosunda SeaFood diye bir kategori ismi var mı varsa sonucu yazdırın.

            bool result = db.Categories.Any(c => c.CategoryName == "SeaFood");
            if (result)
            {
                dgwList.DataSource = db.Categories.Where(c => c.CategoryName == "SeaFood").ToList();
            }
            else
                MessageBox.Show("Kategori Mevcut Değildir.");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Product tablosundaki ürün sayısını yazdırınız.

            int adet = db.Products.Count();
            MessageBox.Show("Ürün Adedimiz: " + adet);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //Stoğumda toplam kaç adet ürün var.

            int? result = db.Products.Sum(c => c.UnitsInStock);  // int? null olan değerleri 0 kabul ederek işlem yapacağını gösteriyor.
            MessageBox.Show("Stok Toplamı: " + result);
        }

        private void btnDataDiff_Click(object sender, EventArgs e)
        {
            //Çalışanların yaşlarını hesaplayınız ve isim soyisim birleşik yazarak yaşlarını yanlarına yazdırınız.

            dgwList.DataSource = db.Employees.Select(x => new
            {
                FullName = x.FirstName + " " + x.LastName,
                BirthDate = x.BirthDate,
                Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
            }).ToList();
        }
    }
}
