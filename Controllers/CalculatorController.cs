using CalculatorTest2.Models;
using CalculatorTest2.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CalculatorTest2.Controllers
{
    public class CalculatorController : Controller
    {
        RestService service  = new RestService();
       
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new CalculatorItems());
        }
       
        // returns the view with calculated result
        [HttpPost]
        public async Task<ActionResult> Index(CalculatorItems item,string calculate)
        {
            if (calculate == "add")
            {
                var result = await service.GetAddAsync(item);
                item.Result = result.Result;
            }

            else if (calculate == "subtract")
            {
                var result = await service.GetSubtractAsync(item);
                item.Result = result.Result;
            }
            else if (calculate == "multiply")
            {
                var result = await service.GetMultiplyAsync(item);
                item.Result = result.Result;
            }
            else
            {
                if (Convert.ToInt32(item.num2) > 0)
                {
                    var result = await service.GetDivideAsync(item);
                    item.Result = result.Result;
                }
            }
            return View(item);

        }
    }
}