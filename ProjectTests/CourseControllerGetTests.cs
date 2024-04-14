using Microsoft.AspNetCore.Mvc;
using simpletest.Controllers;
using simpletest.Interfaces;
using simpletest.Models;
using simpletest.Services;

namespace ProjectTests;

public class CoursesControllerGetTests
{
    private ICourseService _service;
    private CoursesController _controller;

    public CoursesControllerGetTests(){
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

    [Fact]
    public void GetById_WithExistingId_ReturnsOk()
    {
        var result = _controller.GetById(1);

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void GetById_WithNonExistingId_ReturnsNotFound()
    {
        var result = _controller.GetById(0);

        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public void GetById_WithExistingId_ReturnsCorrectCourse()
    {
        var result = _controller.GetById(2) as OkObjectResult;


        Assert.IsType<Course>(result.Value);
        Assert.Equal(2, (result.Value as Course).Id);
        Assert.Equal("PE", (result.Value as Course).Name);
    }
}