using ApiUsuarios.Domain.Interfaces;
using ApiUsuarios.Domain.Models;
using ApiUsuarios.Infra.Data.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace ApiUsuarios.Infra.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}
