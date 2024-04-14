using System.Security.Cryptography.X509Certificates;
using simpletest.Controllers;
using simpletest.Interfaces;
using simpletest.Models;

namespace simpletest.Services;

public class CourseService : ICourseService
{
    private List<Course> _courses = new List<Course>
    {
        new Course {Id = 1, Name = "Math", Price = 12.55M},
        new Course {Id = 2, Name = "PE", Price = 22M}
    };

    public CourseService(){
        //Set Repository
    }

    public IEnumerable<Course> GetAll()
    {
        return _courses;
    }

    public Course GetById(int id)
    {
        var course = _courses.Find(x => x.Id == id);
        return course;
    }

    public Course Add(Course course)
    {
        _courses.Add(course);
        return course;
    }

    public void Remove(Course course)
    {
        throw new NotImplementedException();
    }

    public Course Update(Course course)
    {
        int result = _courses.FindIndex(x => x.Id == course.Id);
        _courses[result] = course;

        return _courses[result];
    }
}