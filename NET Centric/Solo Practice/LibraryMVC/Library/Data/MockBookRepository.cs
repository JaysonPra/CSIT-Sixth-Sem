using Library.Models;

namespace Library.Data
{
    public static class MockRepository
    {
        private static List<Book> _books = new List<Book>
        {
            new Book { Id=1, Title="Designing Machine Learning Systems", Author="Chip Huyen" },
            new Book { Id=2, Title="Something something", Author="Myself" }
        };

        public static List<Book> GetAll() => _books;

        public static Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public static void Add(Book book)
        {
            book.Id = _books.Any() ? _books.Max(b => b.Id) + 1 : 1;
            _books.Add(book);
        }

        public static void Update(Book book)
        {
            var existing = GetById(book.Id);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.Author = book.Author;
            }
        }

        public static void Delete(int id)
        {
            var book = GetById(id);
            if (book != null)
                _books.Remove(book);
        }
    }
}