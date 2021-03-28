using eBook.Models.Books;
using Microsoft.EntityFrameworkCore;

namespace eBook.Models {
    public class BookContext : DbContext {

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }


        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}