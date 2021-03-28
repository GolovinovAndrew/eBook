using eBook.Models.Common;

namespace eBook.Models.Books {
    public class Book : Base {
        public Genre Genre { get; set; }
        public Author Author { get; set; }
    }
}