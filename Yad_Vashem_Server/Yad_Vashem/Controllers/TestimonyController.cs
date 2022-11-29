using DTO;
using Microsoft.AspNetCore.Mvc;
using Yad_Vashem.Service.Interfaces;
using Yad_Vashem.Entities;

namespace Yad_Vashem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonyController : ControllerBase
{
    private ITestimonyService _testimonyService;
    public TestimonyController(ITestimonyService testimonyService)
    {
        _testimonyService = testimonyService;
    }

    // GET/
    [HttpGet()]
    public async Task<ActionResult<TestimonyDTO>> getTestimonyInfo()
    {
        return await _testimonyService.getTestimonyInfo();
    }

    // GET/
    [HttpGet("resource/{type}")]
    public async Task<Resource> getTestimonyResourceByType(ResourceType type)    
    {
        return await _testimonyService.getTestimonyResourceByType(type);
    }
}