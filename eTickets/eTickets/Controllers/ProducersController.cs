using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        //private readonly AppDBContext _context;

        //public ProducersController(AppDBContext context)
        //{
        //    _context = context;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    var allProducers = await _context.Producers.ToListAsync();
        //    return View(allProducers);
        //}
        private readonly IProducerService _service;

        public ProducersController(IProducerService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var producerDetail=await _service.GetByIdAsync(id);
            if (producerDetail == null) return View("Not Found");
            return View(producerDetail);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var producerDetail = await _service.GetByIdAsync(id);
            if (producerDetail == null) return View("Not Found");
            return View(producerDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([Bind("FullName,ProfilePictureURL,Bio")] Producer producer, int id)
        {
            if (!ModelState.IsValid) return View(producer);

            await _service.UpdateAsync(id,producer);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
