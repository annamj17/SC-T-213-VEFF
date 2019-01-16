namespace SchoolApp
{
  public class Student
  {
    public string Name { get; set; }
    public int Age { get; set; }
    
    public override string ToString()
    {
      return  Name + ", " + Age + "\n";
    }
  }
}
