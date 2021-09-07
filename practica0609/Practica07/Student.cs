using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica07
{
    class Student
    {
        public int idStudent { get; set; }

        public string firsName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }
        public int gender { get; set; }

        //crear la coleccion de datos 
        public static List<Student> GetStudents();
      
        public static List<Student> students = new List<Student>
        {
            new Student{ idStudent=1001, firsName="Ana", lastName="Flores",age=22, gender=F},
            new Student{ idStudent=1002, firsName="sofia", lastName="Lopez",age=25, gender=F},
            new Student{ idStudent=1003, firsName="Rafael", lastName="Gomez",age=20, gender=M },
            new Student{ idStudent=1004, firsName="Donato", lastName="Cruz",age=19, gender=M},
            new Student{ idStudent=1005, firsName="Emilio", lastName="Campos",age=22, gender=M},
            new Student{ idStudent=1006, firsName="Alfredo", lastName="Lainez",age=21, gender=M},
            new Student{ idStudent=1007, firsName="Amanda", lastName="Ramirez",age=22, gender=F},
            
        };

        //valor de retorno, sera la lista de estudiantes
        return students;

    }
}


