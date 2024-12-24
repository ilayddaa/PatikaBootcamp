using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Survivor.Data;
using Survivor.Dtos;
using Survivor.Models;

namespace Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetitorController : ControllerBase
{
    private readonly SurvivorDbContext _survivorContext;

    public CompetitorController(SurvivorDbContext survivorContext)
    {
        _survivorContext = survivorContext;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_survivorContext.Competitors.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        Competitor? competitor = _survivorContext.Competitors.FirstOrDefault(x => x.Id.Equals(id));
        if (competitor is null)
            return NotFound();
        return Ok(competitor);
    }

    [HttpGet("category/{categoryId}")]
    public IActionResult GetCategoryId(int categoryId)
    {
        List<Competitor> competitors = _survivorContext.Competitors.Where(x => x.CategoryId.Equals(categoryId)).ToList();
        return Ok(competitors);
    }


    [HttpPost]
    public IActionResult Post(CreateCompetitorDto createCompetitorDto)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        Category? category = _survivorContext.Categories.FirstOrDefault(x => x.Id.Equals(createCompetitorDto.CategoryId));
        if (category is null)
            return NotFound("Kategori bulunamadı!");

        _survivorContext.Competitors.Add(new Competitor
        {
            FirstName = createCompetitorDto.FirstName,
            LastName = createCompetitorDto.LastName,
            CategoryId = createCompetitorDto.CategoryId
        });
        _survivorContext.SaveChanges();
        return Created();
    }

    [HttpPut]
    public IActionResult Put(UpdateCompetitorDto updateCompetitorDto)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        Competitor? competitor = _survivorContext.Competitors.FirstOrDefault(x => x.Id.Equals(updateCompetitorDto.Id));
        if (competitor is null)
            return NotFound();

        competitor.FirstName = updateCompetitorDto.FirstName;
        competitor.LastName = updateCompetitorDto.LastName;
        _survivorContext.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var delete = _survivorContext.Competitors.FirstOrDefault(x => x.Id.Equals(id));
        if (delete is null)
            return NotFound();
        _survivorContext.Remove(delete);
        return NoContent();
    }


}

/* CompetitorController:

GET /api/competitors - Tüm yarışmacıları listele.

GET /api/competitors/{id
}
-Belirli bir yarışmacıyı getir.

GET /api/competitors/categories/{CategoryId} -Kategori Id'ye göre yarışmacıları getir.

POST /api/competitors - Yeni bir yarışmacı oluştur.

PUT /api/competitors/{id} -Belirli bir yarışmacıyı güncelle.

DELETE /api/competitors/{id} -Belirli bir yarışmacıyı sil.*/


