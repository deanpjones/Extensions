using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.TestToConsole
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public double CalculateDiscount(TProduct product)
        {
            return product.Price;   //just returns it, but you get the point
        }   
    }

    public class BookProperties<TBook> where TBook : Book
    {
        public void ShowProperties(TBook book)
        {
            //can access all book properties
            Console.WriteLine("{0}, {1}, {2}", book.Isbn, book.Price, book.Title);
        }
    }

    public class Product
    {
        public double Price { get; set; }
        public string Title { get; set; }
    }

    public class Book : Product
    {
        public string Isbn { get; set; }
    }
}
