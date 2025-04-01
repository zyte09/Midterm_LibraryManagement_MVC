using LibraryManagement_MVC.BusLogic.Model;

namespace LibraryManagement_MVC.BusLogic.Service
{
    public class BookService
    {
        private readonly BookService _bookService = new BookService();

        public IEnumerable<tblBook> GetAll()
        {
            return _bookService.GetAll();
        }

        public bool Add(tblBook book)
        {
            return _bookService.Add(book);
        }

        public tblBook GetBookById(int id)
        {
            return _bookService.GetBookById(id);
        }

        public bool Update(tblBook book)
        {
            return _bookService.Update(book);
        }

        public bool Delete(int id)
        {
            return _bookService.Delete(id);
        }
    }
}
