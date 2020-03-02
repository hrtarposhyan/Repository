using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IStudentRepository
    {
        IList<Student> GetAll();
        Student GetById(int Id);
        void Insert(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}
