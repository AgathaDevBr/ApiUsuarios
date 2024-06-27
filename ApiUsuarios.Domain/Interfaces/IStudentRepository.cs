using ApiUsuarios.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Update(Student student);
        IEnumerable<Student> GetAll();
        Student Get(int id);
        void Delete(int id);
    }
}
