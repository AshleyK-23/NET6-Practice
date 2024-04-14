using simpletest.Models;

namespace simpletest.Data;

public class DataContext{
    public DataContext () {

    }

    public Course Courses { get; set; }

    public Catagory Catagories { get; set; }
}