using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanCanKanBan.DataModel.Interfaces;
using DanCanKanBan.Services.Interfaces;

namespace DanCanKanBan.Web.Controllers
{
    public class HomeController : Controller
    {
        private IConfigurationSettings Settings;
        private IUnitOfWork UnitOfWork;
        private IUserSession UserSession;

        public HomeController(IUnitOfWork unitOfWork, IConfigurationSettings settings, IUserSession session)
        {
            this.Settings = settings;
            this.UnitOfWork = unitOfWork;
            this.UserSession = session;
        }

        public ActionResult Index()
        {
            return View();
        }

       
    }
}