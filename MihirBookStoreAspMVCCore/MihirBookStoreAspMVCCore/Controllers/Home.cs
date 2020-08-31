using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MihirBookStoreAspMVCCore.Controllers
{
    public class Home : Controller
    {
        public string Index()
        {
            return "Mihir New Controller";
        }
    }
}
