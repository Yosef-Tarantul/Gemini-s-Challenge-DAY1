# Library Management System

A simple console application for managing a library's book collection, demonstrating Object-Oriented Programming concepts in C#.

## Features

- **Book Management**: Create and manage books with title, author, ISBN, genre, and location
- **ISBN Validation**: Validates ISBN to ensure it's exactly 13 characters
- **Book Tracking**: Static counter to track total number of books in the library

## OOP Concepts Demonstrated

- **Class**: `Book` class representing a book entity
- **Object**: Instances of the `Book` class
- **Encapsulation**: Private fields with public properties and controlled access
- **Enum**: `Genre` enum for book categories (Fiction, NonFiction, Science, History, Horror, Biography)
- **Record**: `ShelfLocation` record for book's physical location (Aisle, ShelfNumber)
- **Static**: Static field `_bookCount` and static method `GetTotalBooks()` to track total books

## Project Structure

```
Training.OOP/
├── Models/
│   └── Book.cs          # Book class, Genre enum, ShelfLocation record
├── Program.cs           # Main entry point with example usage
└── Training.OOP.csproj  # Project file
```

## How to Run

1. Make sure you have .NET SDK installed
2. Navigate to the project directory
3. Run the following commands:
   ```bash
   dotnet build
   dotnet run
   ```

## Example Usage

```csharp
// Create a new book
Book dracula = new Book("Dracula", "Bram Stoker", "1234567890123", Genre.Horror, new ShelfLocation(1, 2));

// Update ISBN (with validation)
book.UpdateIsbn("9876543210987");

// Get total number of books
int total = Book.GetTotalBooks();
```

## Requirements

- .NET 9.0 or later

git add "OneDrive/שולחן העבודה/Training.OOP/README.md"
git add "OneDrive/שולחן העבודה/Training.OOP/Models/Book.cs"
git add "OneDrive/שולחן העבודה/Training.OOP/Program.cs"
git add "OneDrive/שולחן העבודה/Training.OOP/Training.OOP.csproj"
git rm "OneDrive/שולחן העבודה/Training.OOP/Services/LibraryService.cs"
