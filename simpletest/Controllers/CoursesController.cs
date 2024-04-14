using Microsoft.AspNetCore.Mvc;
using simpletest.Models;

namespace simpletest.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase{
    private List<Course> _courses = new List<Course>
    {
        new Course {Id = 1, Name = "Math", Price = (decimal)12.55},
        new Course {Id = 2, Name = "PE", Price = 22}
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_courses);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var course = _courses.Find(x => x.Id == id);
        if (course == null)
            return NotFound();

        return Ok(course);
    }
}