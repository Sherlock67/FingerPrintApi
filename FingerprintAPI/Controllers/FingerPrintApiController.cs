using FingerprintAPI.Data;
using FingerprintAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FingerprintAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class FingerPrintApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public FingerPrintApiController(ApplicationDbContext db)
        {
            _db = db;

        }

        [HttpPost("FingerPrint")]
        public async Task<Object> CreatePrescription([FromBody] FingerPrint fingerPrint)
        {
            try
            {
                await _db.fingerprints.Add(fingerPrint);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
