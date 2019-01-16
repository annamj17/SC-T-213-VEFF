using System.Collections.Generic;
namespace SchoolApp
{
  public class School
  {
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public School(string name)
    {
      this.Name = name;
      Students = new List<Student>();
    }
    public void AddStudent(Student s) 
    {
      Students.Add(s);
    }
    public override string ToString()
    {
      var result = "School: " + Name + "\n";
      result += "Number of students: " + Students.Count + "\n";
      foreach (var student in Students)
      {
        result += student;
      }
      return result;
    }
  }
}
