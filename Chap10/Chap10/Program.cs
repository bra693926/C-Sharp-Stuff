//File Name: Chap10

//Written By: Brandon Truong

//Date: 07/24/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10
{
    class BookDemo
    {
        static void Main(string[] args)
        {
            Book hello = new Book();
            TextBook bye = new TextBook();

            hello.isbn = "1234567894";
            hello.title = "The Cat in the Hat";
            hello.author = "Dr. Suess";
            hello.price = 4.70;

            bye.isbn = "1255787890";
            bye.title = "Visual C# 2012";
            bye.author = "Farrell";
            bye.grade = "College";
            bye.price = 180.00;

            //Console.WriteLine("ISBN: {0}\n  {1} by {2} sells for {3}", hello.isbn, hello.title, hello.author, hello.price);
            //Console.WriteLine("ISBN: {0}\n  {1} by {2} for {3} sells for {4}", bye.isbn, bye.title, bye.author, bye.grade, bye.price);
            
            Console.WriteLine(hello.ToString());
            Console.WriteLine(bye.ToString());

            Console.ReadLine();
        }
    }
    class Book
    {
        private string _isbn;
        public string isbn
        {
            set
            {
                _isbn = value;

            }
            get
            {
                return _isbn;


            }

        }

        private string _title;
        public string title
        {
            set
            {
                _title = value;

            }
            get
            {
                return _title;


            }

        }

        private string _author;
        public string author
        {
            set
            {
                _author = value;

            }
            get
            {
                return _author;


            }

        }
        protected double _price;   //protected? virtual?
        public virtual double price
        {
            set
            {
                _price = value;

            }
            get
            {
                return _price;


            }

        }

        public override string ToString()
        {
            
            return ("ISBN: " +isbn +"\n  " +title + " by " + author + " sells for " + price.ToString("c"));
        }
    }
    class TextBook : Book
    {
        
        private string _grade;
        public string grade
        {
            set
            {
                _grade = value;

            }
            get
            {
                return _grade;


            }
        }
        
        public override double price
        {
            set
            {
                if (value <= 20)
                {
                    _price = 20;
                }
                else if (value <= 80)
                {
                    _price = 80;

                }
                else
                    _price = value;

            }
            
        }
        public override string ToString()
        {

            return ("ISBN: " + isbn + "\n  " + title + " by " + author + " for grade " + grade + " sells for " + price.ToString("c"));
        }

    }
    
}