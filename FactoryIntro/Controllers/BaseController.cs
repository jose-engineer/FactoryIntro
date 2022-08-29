﻿using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryDP_Intro.Controllers
{
    public class BaseController : Controller
    {
        private ILog _ilog;

        BaseController()
        {
            _ilog = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _ilog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }

        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}