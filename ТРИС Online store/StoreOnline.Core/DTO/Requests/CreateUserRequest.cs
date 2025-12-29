using StoreOnline.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.DTO.Requests
{
    public class CreateUserRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        private CreateUserRequest(string name, string login, string passwordHash)
        {
            Name = name;
            Login = login;
            PasswordHash = passwordHash;
        }

        public static CreateUserRequest Create(string name, string login, string passwordHash)
        {
            return new CreateUserRequest(name, login, passwordHash);
        }
    }
}
