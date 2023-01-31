﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDBContext _context;

        public ActorsController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()//default
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
