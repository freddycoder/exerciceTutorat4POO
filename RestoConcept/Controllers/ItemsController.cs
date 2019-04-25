using Application;
using Application.Data;
using Microsoft.AspNetCore.Mvc;

namespace RestoConcept.Controllers
{
    public class ItemsController : Controller
    {
        private static readonly Executor Executor = new Executor();
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(Executor.Send(new GetAllItem(_context)));
        }

        [HttpPost]
        public IActionResult Create([Bind]Item item)
        {
            Executor.Send(new CreateItem(_context) { Model = item });

            return RedirectToAction(nameof(Index));
        }
    }
}