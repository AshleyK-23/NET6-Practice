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
        IEnumerable<Course> courses = _service.GetAll();
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var course = _service.GetById(id);
        if (course == null){
            return NotFound();
        }

        return Ok(course);
    }
}