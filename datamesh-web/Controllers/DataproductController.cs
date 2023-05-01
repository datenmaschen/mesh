using Microsoft.AspNetCore.Mvc;
using datamesh_web.Interfaces;
using datamesh_web.Models;

namespace datamesh_web.Controllers
{
    public class DataproductController : Controller
    {
        private readonly IDataproductService _service;
        private readonly ILogger<DataproductController> _logger;

        public DataproductController(IDataproductService service, ILogger<DataproductController> logger)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _logger = logger;
        }

        // GET: Dataproduct
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Dataproducts = await _service.Find();
            return View(Dataproducts);
        }

        public async Task<IActionResult> DataproductView(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Dataproduct = await _service.FindById(id);
            return View(Dataproduct);
        }

        // GET: Dataproduct/DataproductCreate
        [HttpGet]
        public IActionResult DataproductCreate()
        {
            return View();
        }

        // I want to create a new Dataproduct
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DataproductCreate(
            [Bind("Key,Name,NameAbbrevationLong,NameAbbreviationShort,SubscriptionName,SubscriptionId,DevOpsProjectName")] DataproductModel Dataproduct)
        {
            if (ModelState.IsValid)
            {
                await _service.Add(Dataproduct);
                return RedirectToAction(nameof(Index));
            }
            return View(Dataproduct);
        }
    }
}