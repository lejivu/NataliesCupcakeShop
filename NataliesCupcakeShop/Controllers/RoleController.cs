using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NataliesCupcakeShop.Data;
using NataliesCupcakeShop.Data.Entities;
using NataliesCupcakeShop.Models;
using System.ComponentModel.DataAnnotations;

namespace NataliesCupcakeShop.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<UserContract> userManager;
        private ApplicationDbContext _context;

        public RoleController(RoleManager<IdentityRole> roleMgr, UserManager<UserContract> userMrg, ApplicationDbContext context)
        {
            roleManager = roleMgr;
            userManager = userMrg;
            _context = context;
        }

        public ViewResult Index() => View(roleManager.Roles);

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            return View(name);
        }

        public async Task<IActionResult> Update(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            List<UserContract> members = new List<UserContract>();
            List<UserContract> nonMembers = new List<UserContract>();
            foreach (UserContract user in userManager.Users.ToList())
            {
                var list = await userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            return View(new RoleEdit
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(RoleModification model)
        {
            IdentityResult result;
            foreach (string userId in model.AddIds ?? new List<string>())
            {
                UserContract user = await userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    result = await userManager.AddToRoleAsync(user, model.RoleName);
                    if (!result.Succeeded)
                        Errors(result);
                }
            }
            foreach (string userId in model.DeleteIds ?? new List<string>())
            {
                UserContract user = await userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
                    if (!result.Succeeded)
                        Errors(result);
                }
            }

            return await Update(model.RoleId);

        }

        public async Task<IActionResult> Delete(string id)
        {
            return Index();
        }
    }
}
