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
    }
}