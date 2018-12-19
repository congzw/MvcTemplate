﻿using System.Web.Http;
using System.Web.Mvc;

namespace Demos.Web
{
    public class MainEntry
    {
        public static void Init()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Init(GlobalConfiguration.Configuration);
            MvcConfig.Init();
        }
    }
}
