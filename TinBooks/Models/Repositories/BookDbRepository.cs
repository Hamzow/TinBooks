using Microsoft.EntityFrameworkCore;
using TinBooks.Models;
using TinBooks.Models.Repositories;

namespace TinBooks.Views.Book
{
    public class BookDbRepository : IBookstoreRepository<Models.Book>
    {
        BookstoreDbContext db;

        public BookDbRepository(BookstoreDbContext _db)
        {
            db = _db;
        }
        public void Add(Models.Book entity)
        {
            db.Books.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Find(id);

            db.Books.Remove(book);
            db.SaveChanges();
        }

        public Models.Book Find(int id)
        {
            var book = db.Books.Include(a => a.Author).SingleOrDefault(b => b.Id == id);

            return book;
        }

        public IList<Models.Book> List()
        {
            return db.Books.Include(a=>a.Author).ToList();        }

        public void Update(int id, Models.Book newBook)
        {
            db.Update(newBook);
            db.SaveChanges();
        }

        public List<Models.Book> Search(string term)
        {
            var result = db.Books.Include(a => a.Author)
                .Where(b => b.Title.Contains(term)
                            || b.Description.Contains(term) 
                            || b.Author.FullName.Contains(term)).ToList();

            return result;
        }
    }
}