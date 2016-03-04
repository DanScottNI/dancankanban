using System.Web.Mvc;
using DanCanKanBan.DataModel.Interfaces;
using DanCanKanBan.Services.Interfaces;
using DanCanKanBan.ViewModels.Models;

namespace DanCanKanBan.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfigurationSettings Settings;
        private readonly IUnitOfWork UnitOfWork;
        private readonly IUserSession UserSession;

        public HomeController(IUnitOfWork unitOfWork, IConfigurationSettings settings, IUserSession session)
        {
            this.Settings = settings;
            this.UnitOfWork = unitOfWork;
            this.UserSession = session;
        }

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();



            return View(model);
        }


    }
}