using ApiUsuarios.Domain.Exceptions.User;
using ApiUsuarios.Domain.Interfaces;
using ApiUsuarios.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Services
{
    /// <summary>
    /// Implementação das regras de negócio para a entidade: User
    /// </summary>
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository? _userRepository;

        public UserDomainService(IUserRepository? userRepository)
        {
            _userRepository = userRepository;
        }

        public User Auth(string userName, string password)
        {
            var user = _userRepository?.Get(userName, password);
            if (user is null)
               throw new AcessoNegadoException();

            //todo gerar token
            return user;
        }

        public void CreateAccount(User user)
        {
            if(_userRepository?.Get(user.UserName) != null)
                throw new UserNameJaCadastradoException();

            //todo gerar os dados de gravação
            _userRepository?.Add(user);
        }
    }

}
