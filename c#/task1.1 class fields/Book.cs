using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1_class_fields
{
    internal class Book:Product
    {
        public string authorName;
        public int pageCount;
        public int discountPercent;
        public Book(string name, string authorName, int costPrice,int saledPrice,  int pageCount, int discountPercent):base(name,costPrice,saledPrice)
        {
            this.authorName = authorName;
            this.pageCount = pageCount;
            this.discountPercent = discountPercent;
        }
        public void GetInfo()
        {
            Console.WriteLine($"name = {this.name} | costprice = {costPirce} ;\nsaledprice = {saledPirce} | author name = {authorName} ;\n page count = {pageCount} | discount percent = {discountPercent} ;\n");
        }
        public double GetDiscountedPrice()
        {
            int discountPercent1= this.discountPercent;
            int saledPirce= this.saledPirce;
            double percent = (discountPercent1 / 100) * (saledPirce);
            return discountPercent/100.0*saledPirce;
        }
    }
}
