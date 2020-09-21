using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Example.MVCWebUI.Models;
using Example.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Example.Business.Abstract;

namespace Example.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly IProjectService _projectService;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, IProjectService projectService)
        {
            _logger = logger;
            _userManager = userManager;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var model = new ProjectListViewModel();

            model.Projects = _projectService.GetUserProjects(_userManager.GetUserAsync(User).Result);

            return View(model);
        }

        public IActionResult CreateProject()
        {
            var model = new CreateProjectViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProject(CreateProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.Title) && !string.IsNullOrEmpty(model.Description))
                {
                    Project project = new Project();
                    project.Title = model.Title;
                    project.Description = model.Description;
                    project.Owner = _userManager.GetUserAsync(User).Result;

                    _projectService.Add(project);

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Title Or Description Cannot Be Null");
                }
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
