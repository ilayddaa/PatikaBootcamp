using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetitorController : ControllerBase
{
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


