using EFandSQLmyTask.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFandSQLmyTask.Models
{
    internal class StudentService
    {
        private static readonly AppDbContext _context = new AppDbContext();

        public List<Student> GetAll()
        {
            var students = _context.Students.ToList();
            return students;
        }

        public Student GetById(int id)
        {
            var students = _context.Students.Find(id);
            return students;
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Delete(int id) 
        {
            var deleted = GetById(id);
            if (deleted != null)
            {
                _context.Students.Remove(deleted);
                _context.SaveChanges();
            }
        }
    }
}
