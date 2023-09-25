namespace WEB_Lab_1.Models;

public class EFDataRepository : IDataRepository
{
    private EFDatabaseContext context;
    
    public EFDataRepository(EFDatabaseContext context)
    {
        this.context = context;
    }
    
    public IEnumerable<Book> Books
    {
        get => context.Books;
        set{}
    }
}