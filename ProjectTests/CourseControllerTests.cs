using Microsoft.AspNetCore.Mvc;
using simpletest.Controllers;
using simpletest.Interfaces;
using simpletest.Models;
using simpletest.Services;

namespace ProjectTests;

public class CoursesControllerTests
{
    private ICourseService _service;
    private CoursesController _controller;

    public CoursesControllerTests(){
        _service = new CourseService();
        _controller = new CoursesController(_service);
    }

    [Fact]
    public void GetAll_Called_ReturnsOk()
    {
        IActionResult result = _controller.GetAll();

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void GetAll_Called_ReturnsAllCourses()
    {
        var resp = _controller.GetAll() as OkObjectResult;
        var result = Assert.IsType<List<Course>>(resp.Value);

        Assert.Equal(2, result.Count);
    }
}