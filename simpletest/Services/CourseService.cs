using System.Security.Cryptography.X509Certificates;
using simpletest.Controllers;
using simpletest.Interfaces;
using simpletest.Models;

namespace simpletest.Services;

public class CourseService : ICourseService
{
    private List<Course> _courses = new List<Course>
    {
        new Course {Id = 1, Name = "Math", Price = (decimal)12.55},
        new Course {Id = 2, Name = "PE", Price = 22}
    };

    public CourseService(){

    }

    public IEnumerable<Course> GetAll()
    {
        throw new NotImplementedException();
    }

    public Course GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Course course)
    {
        throw new NotImplementedException();
    }

    public void Remove(Course course)
    {
        throw new NotImplementedException();
    }

    public void Update(Course course)
    {
        throw new NotImplementedException();
    }
}