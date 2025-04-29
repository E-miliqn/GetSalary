using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Books
    {

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private string author;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        } 
        private bool isAvaliable;
        public bool IsAvailable
        {
            get
            {
                return isAvaliable;
            }
            set
            {
               isAvaliable = value;
            }
        }
        public Books(string title, string author, int year,bool isAvaliable)
        {
            Title = title;           
            Author = author;           
            Year = year;          
            IsAvailable = isAvaliable;   
        }

       
        public void BorrowBook()
        {
            IsAvailable = false;
        }
        public void ReturnBook()
        {
            IsAvailable = true;
        }
    }
}
