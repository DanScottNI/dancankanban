using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using DanCanKanBan.DataModel.DataModels;
using DanCanKanBan.DataModel.Interfaces;
using DanCanKanBan.Services.Interfaces;
using DanCanKanBan.ViewModels.Models;

namespace DanCanKanBan.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IConfigurationSettings Settings;
        private readonly IUnitOfWork UnitOfWork;
        private readonly IUserSession UserSession;

        public HomeController(IUnitOfWork unitOfWork, IConfigurationSettings settings, IUserSession session, IProjectService projectService)
        {
            this.Settings = settings;
            this.UnitOfWork = unitOfWork;
            this.UserSession = session;
            this.projectService = projectService;
        }

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            IEnumerable<Project> projects = projectService.GetAllProjects();

            

            return View(model);
        }


    }
}