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
    
    [HttpGet("{name}")]
    public async Task<ActionResult<Country>> Get(string name)
    {
        Country? country = await _db.Countries.FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower());
        if (country == null)
            country = await _db.Countries.FirstOrDefaultAsync(c => c.OfficialName.ToLower() == name.ToLower());
        if (country == null)
            return NotFound();
        return new ObjectResult(country);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Country>> Delete(int id)
    {
        Country? country = await _db.Countries.FirstOrDefaultAsync(c => c.Id == id);
        if (country == null)
            return NotFound();
        _db.Countries.Remove(country);
        await _db.SaveChangesAsync();
        return Ok(country);
    }

    [HttpPut]
    public async Task<ActionResult<Country>> Put(Country country)
    {
        if (country == null)
            return BadRequest();
        if (!_db.Countries.Any(c => c.Id == country.Id))
            return NotFound();
        _db.Update(country);
        await _db.SaveChangesAsync();
        return Ok(country);
    }

    [HttpPost]
    public async Task<ActionResult<Country>> Post(Country country)
    {
        if (country == null)
            return BadRequest();
        if (_db.Countries.Any(c => c.Id == country.Id))
            return BadRequest();
        _db.Countries.Add(country);
        await _db.SaveChangesAsync();
        return Ok(country);
    }
}