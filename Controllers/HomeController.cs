using Microsoft.AspNetCore.Mvc;
using WEB_Lab_1.Models;

namespace WEB_Lab_1.Controllers;

public class HomeController : Controller
{
    private IDataRepository _repository;
    
    public HomeController(IDataRepository repository)
    {
        _repository = repository;
    }
    
    public IActionResult List()
    {
        return View("ListView", _repository.Books);
    }
}