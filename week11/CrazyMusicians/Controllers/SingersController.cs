using System.IO.Compression;
using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


// 2 Get - 1 Post - 1 Patch - 1 Put - 1 Delete
namespace CrazyMusicians.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SingersController : ControllerBase
{
    private static List<Singer> _singers = new List<Singer>
    {
        new Singer(1, "Sagopa Kajmer", "Rap", "Sabah Fabrikam"),
        new Singer(2, "Emre Fel", "Pop", "Senden Güzeli Mi Var"),
        new Singer(3, "Şebnem Ferah", "Rock", "Bu Aşk Fazla Sana"),
        new Singer(4, "Ayaz Aydın", "Türk Sanat Müziği", "Bir Sivaslı Uğruna"),
        new Singer(5, "Haluk Levent", "Rock", "Yollarda Bulurum Seni"),
        new Singer(6, "Cem Adrian", "Pop", "Sen Gel Diyorsun"),
        new Singer(7, "Tarkan", "Pop", "Kuzu Kuzu"),
        new Singer(8, "Sezen Aksu", "Pop", "Ben De Yoluma Giderim"),
    };

    [HttpGet] // Get: api/singers: Tüm şarkıcıları getirir.
    public IActionResult Get()
    {
        return Ok(_singers);
    }

    [HttpGet("{id}")] // Get: api/singers/1: Id'si 1 olan şarkıcıyı getirir.
    public IActionResult Get(int id)
    {
        var s = _singers.FirstOrDefault(s => s.Id == id);
        if (s is null)
        {
            return NotFound();
        }
        return Ok(s);
    }

    [HttpPost] // Post: api/singers: Şarkıcı eklemesi yapar.
    public IActionResult Post(Singer sng)
    {
        if (!ModelState.IsValid) // Model doğrulama işlemi
        {
            return BadRequest(); // Eğer model doğrulama başarısız olursa 400 Bad Request döner.
        }
        sng.Id = _singers.Max(x => x.Id) + 1; // Listemizdeki en büyük id'ye +1 ekleyerek yeni singer id üretiriz.
        _singers.Add(sng);
        return CreatedAtAction(nameof(Get), new { id = sng.Id }, sng);
    }

    [HttpPatch("{id}")] // Patch: api/singers/1: Id'si 1 olan şarkıcıyı günceller.
    public IActionResult PatchSong(int id, [FromBody] string newSong)
    {
        var sng = _singers.FirstOrDefault(s => s.Id == id);
        if (sng is null)
        {
            return BadRequest();
        }
        sng.BestSong = newSong;
        return Accepted();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Singer updateSinger)
    {
        var sng = _singers.FirstOrDefault(x => x.Id == id);
        if (sng is null)
        {
            return BadRequest();
        }
        sng.Id = updateSinger.Id;
        sng.BestSong = updateSinger.BestSong;
        sng.Genre = updateSinger.Genre;
        sng.Name = updateSinger.Name;

        return AcceptedAtAction(nameof(Get), new { id = updateSinger.Id }, updateSinger);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var sng = _singers.FirstOrDefault(x => x.Id == id);
        if (sng is null)
        {
            return BadRequest();
        }
        _singers.Remove(sng);
        return NoContent();
    }

    [HttpGet("search")]
    public IActionResult Search([FromQuery] string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return BadRequest();
        }
        var singers = _singers.Where(x => x.Name.Contains(query)).ToList();
        return Ok(singers);

    }
}

