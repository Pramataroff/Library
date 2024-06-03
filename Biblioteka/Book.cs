using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Book
    {
        public string title;
        public string author;
        public string jenre;
        private bool onstock;

        public bool Onstock
        {
            get { return onstock; }
            set { onstock = value; }
        }
        public void Bookinfo()
        {
            Console.WriteLine($"Zaglavie {this.title} s janr {this.jenre} ot {this.author} s nalichnost ot {this.onstock} broiki.");
            if (Onstock) { Console.WriteLine("ima nalichnost"); }
            else { Console.WriteLine(" nqma nalichnost"); }
        }
        public void Customs()
        {
            Console.WriteLine("What do you want, to return or buy book. \n If you want to buy book type \"BUY\" \n if you want to return type \"RETURN\" ");
            string question = Console.ReadLine();
            if (question == "BUY")
            {
                if (Onstock)
                {
                    Console.WriteLine("The book is booked");
                    Onstock = false;
                }
                else
                {
                    Console.WriteLine("The book is unavailable");
                }
            }
            else if (question == "RETURN")
            {
                if (Onstock)
                {
                    Console.WriteLine("The book is already available");
                }
                else
                {
                    Console.WriteLine("The book is successfully returned!");
                    Onstock = true;                
                }
            }
        }
    }
}
