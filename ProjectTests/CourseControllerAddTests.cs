using Microsoft.AspNetCore.Mvc;
using simpletest.Controllers;
using simpletest.Interfaces;
using simpletest.Models;
using simpletest.Services;

namespace ProjectTests;

public class CoursesControllerAddTests
{
    private ICourseService _service;
    private CoursesController _controller;
    private Course _testCourse;

    public CoursesControllerAddTests(){
        _service = new CourseService();
        _controller = new CoursesController(_service);
        _testCourse = new Course { Id = 3, Name = "Art", Price = 70M };
    }

    [Fact]
    public void Add_WithoutExistingCourse_ReturnsCreatedAtAction()
    {
        var result = _controller.Add(_testCourse);

        Assert.IsType<CreatedAtActionResult>(result);
    }

    [Fact]
    public void Add_WithExistingCourse_ReturnsBadRequest()
    {
        _testCourse.Id = 1;
        var result = _controller.Add(_testCourse);

        Assert.IsType<BadRequestResult>(result);
    }

    [Fact]
    public void Add_WithoutExistingCourse_ReturnsNewCourseFromList()
    {
        var createdResult = _controller.Add(_testCourse) as CreatedAtActionResult;
        var result = createdResult.Value;

        Assert.IsType<Course>(result);
        Assert.Equal(_testCourse.Id, (result as Course).Id);
        Assert.Equal(_testCourse.Name, (result as Course).Name);
    }

    //Test for incomplete Course body
}