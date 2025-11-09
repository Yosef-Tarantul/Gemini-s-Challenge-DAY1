using System;


namespace Training.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Book dracula = new Book("Dracula", "Bram Stoker", "1234567890123", Genre.Horror, new ShelfLocation(1, 2));
            Book MickeyMouse = new Book("MicekyMouse", "Walt Disney", "2765234817214", Genre.Biography, new ShelfLocation(1,1));

            //dracula.UpdateIsbn("2718");
            MickeyMouse.UpdateIsbn("2876543212345");
            
            int total = Book.GetTotalBooks();
            Console.WriteLine($"Total books: {total}");


            try
            {
                Book Rickey = new Book("Rickey", "Walt Disney", null , Genre.Biography, new ShelfLocation(1,3));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error creating book: {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Creating book succeded!");
            }
        }
    }
}


