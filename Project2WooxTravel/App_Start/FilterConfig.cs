﻿using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
