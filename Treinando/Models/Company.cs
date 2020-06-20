using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinando.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Client> Clients { get; set; } = new List<Client>();

        public Company()
        {
        }

        public Company(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
