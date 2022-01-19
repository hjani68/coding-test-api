using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee(CancellationToken cancellationToken)
        {
            try
            {
                var employeeList = await _employeeService.GetAllEmployee();
                return Ok(employeeList);
            }
            catch (Exception exception)
            {
                return new ContentResult
                {
                    StatusCode = exception is ValidationException ? StatusCodes.Status400BadRequest : StatusCodes.Status500InternalServerError,
                    ContentType = MediaTypeNames.Application.Json,
                    Content = JsonConvert.SerializeObject(new { Error = exception.GetBaseException().Message }, Formatting.Indented)

                };
            }
        }
    }
}