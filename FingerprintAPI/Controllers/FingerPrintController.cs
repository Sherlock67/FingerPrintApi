using FingerprintAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace FingerprintAPI.Controllers
{
    public class FingerPrintController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FingerPrintController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
