using System.Collections.Generic;
using simpletest.Models;

namespace simpletest.Interfaces;

public interface ICourseService{
    public IEnumerable<Course> GetAll();
    public Course GetById(int id);
    public void Add(Course course);
    public Course Update(Course course);
    public void Remove(Course course);
}