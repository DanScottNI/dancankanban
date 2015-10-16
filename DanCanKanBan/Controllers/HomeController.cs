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
        public HomeController(IUnitOfWork unitOfWork, IConfigurationSettings settings)
        {
            this.Settings = settings;
            this.UnitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return View();
        }

       
    }
}