using System;
using System.Collections.Generic;
using System.Text;

namespace BookManaging_oop
{
    interface Ibook
    {
        // Mô tả index chương sách
        string this[int index]
        {
            get;
            set;
        }
        // property title đại diện cho tên của sách
        string Title
        {
            get;
            set;
        }
        // đại diện cho tên tác giả của cuốn sách
        string Author
        {
            get;
            set;
        }
        // đại diện cho tên nhà sản xuất
        string Publisher
        {
            get;
            set;
        }
        string ISBN
        {
            get;
            set;
        }
        // đại diện cho năm xuất bản
        int Yeat
        {
            get;
            set;
        }
        // Mô tả phương thức hiển thị thông tin cuốn sách
        void Show();
    }
}