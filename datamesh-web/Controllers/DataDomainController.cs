using Microsoft.AspNetCore.Mvc;
using datamesh_web.Interfaces;
using datamesh_web.Models;

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

        // I want to create a new DataDomain
        public async Task<IActionResult> DataDomainCreate(
            [Bind("Name,Description") ]DataDomainModel datadomain)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Add(datadomain);
                    await _service.add();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(datadomain);
        }
    }
}