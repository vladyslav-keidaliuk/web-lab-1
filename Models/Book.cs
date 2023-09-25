namespace WEB_Lab_1.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Category { get; set; }
    public decimal Price { get; set; }
    
    
    public Book()
    {
    }
    
    public Book(string title, string category, decimal price)
    {
        Title = title;
        Category = category;
        Price = price;
    }
}