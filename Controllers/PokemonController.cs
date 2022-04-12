using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Poke.Controllers
{
    public class PokemonController : Controller
    {
        private readonly Poke.Data.AppContext _appContext;
        public PokemonController(Poke.Data.AppContext appContext)
        {
            _appContext = appContext;
        }
        public IActionResult Home1()
        {
            var pokes = _appContext.Pokemons.ToList();
            return View(pokes);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
