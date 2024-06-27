using ApiUsuarios.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Interfaces
{
    public interface IStudentDomainService 
    {
        void CreateStudent(Student student);
        void UpdateStudent(int id, Student student);
        void DeleteStudent(int id);
        Student GetStudentById(int id);
        IEnumerable<Student> GetAllStudents();
    }
}
