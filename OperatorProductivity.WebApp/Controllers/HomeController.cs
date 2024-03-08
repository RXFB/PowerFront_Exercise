using MediatR;
using Microsoft.AspNetCore.Mvc;
using OperatorProductivity.Application.DTO;
using OperatorProductivity.Application.Queries;
using OperatorProductivity.Data;
using OperatorProductivity.WebApp.Models;
using System.Diagnostics;

namespace OperatorProductivity.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<ActionResult> OperatorReportAsync(OperatorProductivityResultQueryFilter filter)
        {
            var result = await _mediator.Send(new GetOperatorProductivityResultQuery()
            {
                Filter = filter
            });

            return View(result);
        }

        public async Task<FilterValuesDTO> GetFilterValuesAsync(OperatorProductivityResultQueryFilter filter)
        {
            var result = await _mediator.Send(new GetFilterValuesQuery());

            return result;
        }

        public ActionResult OperatorProductivityData()
        {
            return View();
        }
    }
}
