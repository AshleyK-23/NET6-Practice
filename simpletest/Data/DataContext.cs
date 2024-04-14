namespace simpletest.Data;
using simpletest.Models;

public class DataContext{
    public DataContext () {

    }

    public Course Courses { get; set; }

    public Catagory Catagories { get; set; }
}