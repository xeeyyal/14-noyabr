using EFandSQLmyTask.DAL;
using EFandSQLmyTask.Models;

namespace EFandSQLmyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();


            //GetAll methodu
            //List<Student> students = studentService.GetAll();
            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"{item.Id} Name: {item.Name} Surname: {item.Surname} AvgPoint: {item.AvgPoint}");
            //}



            //---------------------------------------------------------
            //GetById methodu
            //Student student = studentService.GetById(3);

            //Console.WriteLine($"{student.Id} Name: {student.Name} Surname: {student.Surname} AvgPoint: {student.AvgPoint}");



            //---------------------------------------------------------
            //Create methodu
            //Student student1 = new Student
            //{
            //    Name = "Xeyal",
            //    Surname = "Huseynov",
            //    AvgPoint = 97
            //};

            //studentService.Create(student1);


            studentService.Create(new Student
            {
                Name = "Xeyal",
                Surname = "Huseynov",
                AvgPoint = 97
            });



            //---------------------------------------------------------
            //Delete methodu
            //studentService.Delete(3);
            //Console.WriteLine("Silinenden sora butun telebeler:");
            //foreach (Student item in students)
            //{
            //    Console.WriteLine($"{item.Id} Name: {item.Name} Surname: {item.Surname} AvgPoint: {item.AvgPoint}");
            //}
        }
    }
}