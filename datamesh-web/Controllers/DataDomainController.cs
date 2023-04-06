using Microsoft.AspNetCore.Mvc;
using datamesh_web.Interfaces;

namespace datamesh_web.Controllers
{
    public class DataDomainController : Controller
    {
        private readonly IDataDomainService _service;

        public DataDomainController(IDataDomainService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> DataDomainIndex()
        {
            var products = await _service.Find();
            return View(products);
        }
    }
}