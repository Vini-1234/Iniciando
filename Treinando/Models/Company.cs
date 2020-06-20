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
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public virtual ICollection<SalesRecord> SalesRecords { get; set; }
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
