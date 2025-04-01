using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_MVC.BusLogic.Model
{
    public class tblBook
    {
        [Key]
        public int id { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public DateTime datePublished { get; set; }
    }
}
