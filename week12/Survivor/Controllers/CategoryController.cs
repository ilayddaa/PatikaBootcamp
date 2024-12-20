using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Data;
using Survivor.Dtos;
using Survivor.Models;

namespace Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly SurvivorDbContext _survivorContext; //add generate cons.

    public CategoryController(SurvivorDbContext survivorContext)
    {
        _survivorContext = survivorContext;
    }


    /*GET /api/categories - Tüm kategorileri listele.

    GET /api/categories/{id
    } - Belirli bir kategoriyi getir.

    POST /api/categories - Yeni bir kategori oluştur.

    PUT /api/categories/{ id} - Belirli bir kategoriyi güncelle.

    DELETE /api/categories/{ id} - Belirli bir kategoriyi sil.*/


    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_survivorContext.Categories.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        var getone = _survivorContext.Categories.FirstOrDefault(x => x.Id.Equals(id));
        if (getone is null)
        {
            return NotFound();
        }
        return Ok(getone);
    }

    [HttpPost]
    public IActionResult Post(CreateCategoryDto newcategory)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        Category category = new Category { Name = newcategory.Name };
        _survivorContext.Add(category);
        _survivorContext.SaveChanges();
        return Created();
    }

    [HttpPut]
    public IActionResult Put(UpdateCategoryDto newupdate)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var updateCategory = _survivorContext.Categories.FirstOrDefault(x => x.Id.Equals(newupdate.Id));
        if (updateCategory is null)
            return BadRequest();
        updateCategory.Name = newupdate.Name;
        _survivorContext.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var delete = _survivorContext.Categories.FirstOrDefault(x => x.Id.Equals(id));
        if (delete is null)
            return NotFound();
        _survivorContext.Categories.Remove(delete);
        return NoContent();
    }

}


