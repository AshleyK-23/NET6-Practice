using Microsoft.AspNetCore.Mvc;
using simpletest.Controllers;

namespace ProjectTests;

public class UnitTest1
{
    CoursesController _controller;

    [Fact]
    public void Test1()
    {
        IActionResult result = _controller.GetAll();
        Assert.IsType<OkResult>(result);
    }
}