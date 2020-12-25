using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_AbstractClasses
{
    public class MyBook : Book
    {
        public MyBook(string title, string author, int price) : base(title, author)
        {
            Price = price;
        }

        int Price { get; set; }
        public override void display()
        {

            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {Price}");
        }
    } 
}
