

//Define enum for Genres.
public enum Genre {Fiction, NonFiction, Science, History, Horror, Biography}; 
//Define a record data for physical location of the books in the library.
public record ShelfLocation( int Aisle, int ShelfNumber);
// The Book class itself.
public class Book
{


    public string title {get; private set;}                                    // A book's title.
    public string author {get; private set;}                                  // A book's author.
    public string isbn {get; private set;}                                   // A book's ISBN which stands for the "International Standard Book Number".
    public Genre genre{get; private set;}                                    // A book's genre -> uses the enum genre.
    public ShelfLocation location{get; private set;}                        // A book's physical location -> uses the record ShelfLocation.
    private static int _bookCount = 0;                                      // A private static number to keep track on the amount of books in the library.


// The Constructor.
    public Book(string Title, string Author, string Isbn, Genre Genre, ShelfLocation Location) 
    {
        this.title = Title;
        this.author = Author;
        this.isbn = Isbn;
        if(string.IsNullOrEmpty(Isbn)) 
        {
            throw new ArgumentNullException(nameof(isbn));
        }
        this.genre = Genre;
        this.location = Location;
        _bookCount++;
    }
    // Update a book's ISBN.
    public void UpdateIsbn(string newIsbn)
    {
        if(newIsbn.Length != 13)
        throw new ArgumentException("ISBN must be exactly 13 characters. ");

        isbn = newIsbn;
        
        
    }
    // Get the total amount of books in the library.
    public static int GetTotalBooks()
    {
    return _bookCount;
    }




}