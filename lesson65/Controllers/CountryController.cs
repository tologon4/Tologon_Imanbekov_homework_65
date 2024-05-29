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

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Country>> Get(int id)
    {
        Country? country = await _db.Countries.FirstOrDefaultAsync(c => c.Id == id);
        if (country == null)
            return NotFound();
        return new ObjectResult(country);
    }
    
    
}