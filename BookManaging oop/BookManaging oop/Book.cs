using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookManaging_oop
{
    class Book :Ibook
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        // lưu trư mảng chưa tên chương 
        private ArrayList chapter = new ArrayList();

        #region thwuc thi giao diện IBook
        public string this[int index]// index chương sách
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();

            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                   chapter[index] = value ;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        #endregion
        public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Publisher
        {
            get;
            set;
        }
        public string ISBN
        {
            get;
            set;
        }
        public int Yeat
        {
            get;
            set;
        }
        public void Show() {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Aythor: " + author);
            Console.WriteLine("Publisher " + publisher);
            Console.WriteLine("Year:  " + year);
            Console.WriteLine("Chapter ");
            for(int i = 0; i< chapter.Count; i++)
            {
                Console.WriteLine("\t {0}: {1} ", i + 1, chapter[i]);
            }
            Console.WriteLine("-----------------------------");
        }

        public void Input()
        {
            Console.Write("Title:  ");
            title = Console.ReadLine();
            Console.Write("Author:  ");
            author = Console.ReadLine();
            Console.Write("Publisher:  ");
            publisher = Console.ReadLine();
            Console.Write("ISBN:  ");
            isbn = Console.ReadLine();
            Console.Write("Year:  ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chaper ( finisher with empty string)");
            string str;
            int i = 0;
            do
            {
                i++;
                Console.Write("Chương {0}",i);
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);
        }

    }
    class BookList
    {// định nghia danh sách book
        private ArrayList list = new ArrayList();
        // tạo một đối tượng sách, nhập các thông tin thêm vao list
        public void AddBook()
        {
            Book b = new Book();
            // nhập thông tin
            b.Input();

            list.Add(b);
        }
        public void showList()
        {
            foreach (Book b in list)
                b.Show();
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books:");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
    }
}
