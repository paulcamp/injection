using System.Web.Mvc;
using WebSales.Models;

namespace WebSales.Controllers
{
    public class EmptyController : Controller
    {
        private readonly IStockEngine _stockEngine;

        public EmptyController(IStockEngine stockEngine)
        {
            _stockEngine = stockEngine;
        }

        // GET: Empty
        public ActionResult Index()
        {
            var item = _stockEngine.LookupItem(1);
            ViewData.Add("stock", item);

            return View();
        }
    }
}