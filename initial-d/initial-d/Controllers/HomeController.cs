﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using initial_d.Common;

namespace initial_d.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ErrMsg = TempData["ErrorMessage"] ?? null;

            SetNavbar();
            return View();
        }

        public ActionResult About()
        {
            SetNavbar();
            return View();
        }

        public ActionResult Contact()
        {
            SetNavbar();
            return View();
        }

        private void SetNavbar()
        {
            List<NavbarItems> InternalNavbar = new List<NavbarItems>()
            {
                new NavbarItems("Home", "Index", "Inicio"),
                new NavbarItems("Home", "About", "Acerca de Nosotros"),
                new NavbarItems("Home", "Contact", "Contacto"),
            };

            ViewBag.InternalNavbar = InternalNavbar;
        }
    }
}