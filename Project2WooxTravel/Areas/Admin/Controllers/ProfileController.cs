﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        public ActionResult Index()
        {
            return View();
        }
    }
}