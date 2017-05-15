using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMVVM.Model;
using XMVVM.Storage;

namespace XMVVM.Services
{
    class StudentDirectoryService
    {

       public static StudentDirectory loadStudentDirectory()
       {
            DatabaseManager dbManager = new DatabaseManager();
            ObservableCollection<Student> students = new ObservableCollection<Student>(dbManager.GetAllItems<Student>());
            StudentDirectory studentDirectory = new StudentDirectory();

            if (students.Any())
            {
                studentDirectory.Students = students;
                return studentDirectory;
            }

            students = new ObservableCollection<Student>();

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
                student.Key = student.StudentNumber;
                student.Average = rdn.Next(100, 1000) / 10;
                students.Add(student);
                dbManager.SaveValue<Student>(student);
            }
            studentDirectory.Students = students;
            return studentDirectory;
        }

    }
}
