using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMVVM.Model;

namespace XMVVM.Services
{
    class StudentDirectoryService
    {

       public static StudentDirectory loadStudentDirectory()
       {
            StudentDirectory studentDirectory = new StudentDirectory();
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            string[] names = {
            "Andres Felipe",
            "Sebastian",
            "Alvaro",
            "Ediney",
            "Jose Miguel",
            "Daniela",
            "Camila",
            "Carolina"
            };

            string[] lastName = {
            "Polo",
            "Estupiñan",
            "Vargas",
            "Perez",
            "Galan"
            };

            Random rdn = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 20; i++)
            {
                Student student = new Student();
                student.Name = names[rdn.Next(0, 7)];
                student.LastName = lastName[rdn.Next(0,4)];
                student.Group = rdn.Next(456,458).ToString();
                student.StudentNumber = rdn.Next(12384748, 32384748).ToString();
                student.Average = rdn.Next(100, 100) / 10;
                students.Add(student);
            }
            studentDirectory.Students = students;
            return studentDirectory;
        }

    }
}
