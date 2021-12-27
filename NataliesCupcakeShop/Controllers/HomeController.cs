using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NataliesCupcakeShop.Data;
using NataliesCupcakeShop.Data.Entities;
using NataliesCupcakeShop.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace NataliesCupcakeShop.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }


        public IActionResult Index(bool test = false) 
        {
            if(User.IsInRole("Admin") && !test)
            {
                return RedirectToAction("Admin");
            }
            return View();
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Admin()
        {

            return View(_context.Users.Where(x => !x.isDeleted).ToList());
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            UserContract user = new UserContract();
            if (!string.IsNullOrWhiteSpace(id))
            {
                user = _context.Users.FirstOrDefault(x => x.Id == id) ?? new UserContract();
            }
            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(UserContract model)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == model.Id);
            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Country = model.Country;
                user.ZipCode = model.ZipCode;
                user.DateOfBirth = model.DateOfBirth;
                user.Email = model.Email;
            }
            else
            {
                model.CreateDate = DateTime.Now;
                _context.Add(model);
            }

            _context.SaveChanges();
            return RedirectToAction("Admin");

        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {

            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (user != null)
            {
                user.isDeleted = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Admin");
        }
    }
}