﻿using System.Web;
using System.Web.Mvc;

namespace FinalExam410716152
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}