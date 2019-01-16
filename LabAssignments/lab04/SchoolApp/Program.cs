using System;

namespace SchoolApp
{
  public class Program
    {
        static void Main(string[] args)
        {
            School sch = new School( "HR" );
            sch.AddStudent( new Student { Name = "Nonni", Age = 22 });
            sch.AddStudent( new Student { Name = "Sigga", Age = 23 });
            Console.WriteLine( sch );
        }
    }
}
