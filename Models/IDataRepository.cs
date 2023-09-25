namespace WEB_Lab_1.Models;

public interface IDataRepository
{
    IEnumerable<Book> Books { get; set; }
}