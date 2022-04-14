using Games.Models;
using Microsoft.AspNetCore.Mvc;

namespace Games.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Play(string guess)
        {
            game obj = new game();
            obj.guess = guess;
            return View(obj);
        }
    }
}
