using eBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBook.Controllers {
    public class ShopController : Controller {
        private BookContext _db;
        
        public ShopController(BookContext context) {
            _db = context;
        }

        [HttpGet]
        public IActionResult MainPage()
        {
            return View();
        }
    }
}