using Microsoft.AspNetCore.Mvc;
using simpletest.Controllers;
using simpletest.Interfaces;
using simpletest.Models;
using simpletest.Services;

namespace ProjectTests;

public class CoursesControllerUpdateTests
{
    CoursesController _controller;
    ICourseService _service;
    Course _testCourse;

    public CoursesControllerUpdateTests() {
        _service = new CourseService();
        _controller = new CoursesController(_service);
        _testCourse = new Course { Id = 1, Name = "Art", Price = 70M };
    }

    [Fact]
    public void Update_WithNonExistingCourse_ReturnsNotFound()
    {
        _testCourse.Id = 3;
        var result = _controller.Update(_testCourse);

        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public void Update_WithExistingCourse_ReturnsOk()
    {
        var result = _controller.Update(_testCourse);

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void Update_WithExistingCourse_ReturnsCourseFromList()
    {
        var okResult = _controller.Update(_testCourse) as OkObjectResult;
        var result = okResult.Value;

        Assert.IsType<Course>(result);
        Assert.Equal(_testCourse.Id, (result as Course).Id);
        Assert.Equal(_testCourse.Name, (result as Course).Name);
    }

    // Update_WithExistingCourseWithoutPrice_ReturnsCorrectCourseWithPrice
}