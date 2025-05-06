using ChmuryProj.Api.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChmuryProj.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KomentarzeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KomentarzeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost()]
        public async Task<IActionResult> AddKomentarz([FromBody] KomentarzPost komentarz)
        {
            KomentarzEntity komentarzEntity = new KomentarzEntity()
            {
                Message = komentarz.Message,
                Name = komentarz.Name,
            };

            await _context.Komentarze.AddAsync(komentarzEntity);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet()]
        public async Task<ActionResult<KomentarzEntity>> GetKomentarze()
        {
            var kometarze = await _context.Komentarze.ToListAsync();

            return Ok(kometarze);
        }
        //public async Task<ActionResult<KomentarzEntity>> GetKomentarze()
        //{ 
        //    var entity = await _context.Komentarze.GetA
        //}

        public class KomentarzPost
        {
            public string Message { get; set; }
            public string Name { get; set; }
        }
    }
}
