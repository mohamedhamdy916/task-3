namespace task_3
{
    public class Book
    {
        public string title;
        public string auther;
        public string ISBN;
        public string Available;

        public Book(string title, string auther, string iSBN, string available = "True")
        {
            this.title = title;
            this.auther = auther;
            this.ISBN = iSBN;
            this.Available = available;
        }
        public void Getter()
        {
            

        }


    }
    public class library
    {
        public List<Book> books;

        public library()
        {
            books = new List<Book>();
        }
        public void AddBook(string title, string auther, string iSBN)
        {
            books.Add(new Book(title, auther, iSBN));
        }
        public void BorrowBooks(string title)
        {
            Console.WriteLine("Enter title or authur :");
            Book a;
            if (title!= a.title || a.auther!= title) {
                Console.WriteLine("This book is not in the library");
            }
        }
        public void ReturnBook(string title)
        {
            Book b; 
            while (b.title == title)
            {
                Console.WriteLine("This book is not borrowed");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                
                library a = new library();
                a.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565");
                a.BorrowBooks("Gatsby");


            }
        }
    }
}
