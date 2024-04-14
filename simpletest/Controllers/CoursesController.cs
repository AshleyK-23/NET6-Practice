using Microsoft.AspNetCore.Mvc;
using simpletest.Interfaces;
using simpletest.Models;

namespace simpletest.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase{

    private ICourseService _service;
    public CoursesController(ICourseService service){
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var course = _service.GetById(id);

        return Ok(course);
    }
}