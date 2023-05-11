using Microsoft.AspNetCore.Mvc;
using datamesh_web.Interfaces;
using datamesh_web.Models;

namespace datamesh_web.Controllers
{
    public class DataDomainController : Controller
    {
        private readonly IDataDomainService _service;
        private readonly ILogger<DataDomainController> _logger;

        public DataDomainController(IDataDomainService service, ILogger<DataDomainController> logger)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _logger = logger;
        }

        public async Task<IActionResult> DataDomainIndex()
        {
            var datadomains = await _service.Find();
            return View(datadomains);
        }

        public async Task<IActionResult> DataDomainView(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datadomain = await _service.FindById(id);
            return View(datadomain);
        }

        // GET: DataDomain/DataDomainCreate
        [HttpGet]
        public IActionResult DataDomainCreate()
        {
            return View();
        }

        // I want to create a new DataDomain
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DataDomainCreate(
            [Bind("Key,Name,NameAbbreviationLong,NameAbbreviationShort,SubscriptionName,SubscriptionId,DevOpsProjectName")] DataDomainModel datadomain)
        {
            if (ModelState.IsValid)
            {
                await _service.Add(datadomain);
                return RedirectToAction(nameof(DataDomainIndex));
            }
            return View(datadomain);
        }
    }
}