using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace darkeyedragon.me.Areas.Plugins.Controllers
{
    public class RandomTeleportController : RandomTeleportBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
