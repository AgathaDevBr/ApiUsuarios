using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Exceptions.Student
{
    public class StudentJaCadastradoException : Exception
    {
        public override string Message => "Estudante já cadastrado.";
    }
}
