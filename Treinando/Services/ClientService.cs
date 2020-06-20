
using System.Collections.Generic;
using System.Linq;
using Treinando.Data;
using Treinando.Models;

namespace Treinando.Services
{
    public class ClientService
    {
        private readonly TreinandoContext _context;

        public ClientService(TreinandoContext context)
        {
            _context = context;
        }
        public List<Client> FindAll()
        {
            return _context.Client.ToList();
        }
        public void Insert(Client obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

