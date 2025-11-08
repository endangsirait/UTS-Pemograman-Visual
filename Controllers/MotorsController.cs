using Microsoft.AspNetCore.Mvc;
using Dealermotor.Models;
using Dealermotor.Services;
using MongoDB.Driver;

namespace Dealermotor.Controllers
{
    public class MotorsController : Controller
    {
        private readonly MongoDBService _mongoDBService;

        public MotorsController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        // GET: Motors (List all motors)
        public async Task<IActionResult> Index()
        {
            var motors = await _mongoDBService.Motors.Find(_ => true).ToListAsync();
            return View(motors);
        }

        // GET: Motors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motors/Create
        [HttpPost]
        public async Task<IActionResult> Create(Motor motor)
        {
            motor.CreatedAt = DateTime.Now;
            await _mongoDBService.Motors.InsertOneAsync(motor);
            return RedirectToAction("Index");
        }

        // GET: Motors/Edit/id
        public async Task<IActionResult> Edit(string id)
        {
            var motor = await _mongoDBService.Motors
                .Find(m => m.Id == id)
                .FirstOrDefaultAsync();
            return View(motor);
        }

        // POST: Motors/Edit/id
        [HttpPost]
        public async Task<IActionResult> Edit(string id, Motor motor)
        {
            var filter = Builders<Motor>.Filter.Eq(m => m.Id, id);
            await _mongoDBService.Motors.ReplaceOneAsync(filter, motor);
            return RedirectToAction("Index");
        }

        // GET: Motors/Delete/id
        public async Task<IActionResult> Delete(string id)
        {
            var filter = Builders<Motor>.Filter.Eq(m => m.Id, id);
            await _mongoDBService.Motors.DeleteOneAsync(filter);
            return RedirectToAction("Index");
        }

        // GET: Motors/Details/id
        public async Task<IActionResult> Details(string id)
        {
            var motor = await _mongoDBService.Motors
                .Find(m => m.Id == id)
                .FirstOrDefaultAsync();
            return View(motor);
        }
    }
}

