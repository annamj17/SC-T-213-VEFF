fusing System.Collections.Generic;
using Lab6.Models;

namespace Lab6
{
    public static class FakeDatabase
    {
        public static List<Student> Students= new List<Student>()
        {
            new Student { Age = 27, Name = "John" },
            new Student { Age = 23, Name = "Terry" },
            new Student { Age = 24, Name = "Alice" },
            new Student { Age = 26, Name = "Sara" },
            new Student { Age = 56, Name = "Robert" },
            new Student { Age = 32, Name = "Jack" }
        };
    }
}