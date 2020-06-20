using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinando.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Company> Companies { get; set; }

        public Client()
        {
        }

        public Client(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
