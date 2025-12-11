using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TariffCalculator.Api.Models;
using TariffCalculator.Api.Services;

namespace TariffCalculator.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{

    public HomeController()
    {
    }

    [HttpGet("Index")]
    public IActionResult Index()
    {
        
        return Ok(new { message = "Launched Home Page" });
    }

}