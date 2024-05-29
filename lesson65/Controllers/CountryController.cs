using lesson65.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lesson65.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CountryController : Controller
{
    private CountryDb _db;

    public CountryController(CountryDb db)
    {
        _db = db;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Country>>> Get()
    {
        return await _db.Countries.ToListAsync();
    }

    
}