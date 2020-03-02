using Repository.Data;
using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Context _context;
        public StudentRepository(Context context)
        {
            _context = context;
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
        }

        public IList<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int Id)
        {
            var student = _context.Students.Where(x => x.Id == Id).FirstOrDefault();
            return student;
        }

        public void Insert(Student student)
        {
            _context.Students.Add(student);
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
        }
    }
}
