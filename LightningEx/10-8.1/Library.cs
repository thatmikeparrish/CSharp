using System;
using System.Collections.Generic;

namespace Library {
    public class Library {
        public Library (List<Book> initialInventory, string name, string address) {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }

        private List<Book> _bookList = new List<Book> ();

        public void AddToInventory (Book book) {
            _bookList.Add (book);
        }

        public void Checkout (string isbn, CardHolder cardHolder) {
            Book foundBook = new Book();

            foreach (Book book in _bookList) {
                if (book.ISBN == isbn && book.IsAvailable) {

                    foundBook = book;

                    cardHolder.CheckoutBook (foundBook);
                    foundBook.IsAvailable = false;
                }
            }
        }

        public bool IsAvailable(string isbn) {
            foreach(Book book in _bookList) {
                if(book.ISBN == isbn) {
                    return book.IsAvailable;
                }
            }
            return false;
        }
    }
}