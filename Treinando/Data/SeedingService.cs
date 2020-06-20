using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Treinando.Models;

namespace Treinando.Data
{
    public class SeedingService
    {
        private readonly TreinandoContext _context;

        public SeedingService(TreinandoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Client.Any())
            {
                return;
            }

            var c1 = new Client(1, "Joao", "joao@gmail.com");
            var c2 = new Client(2, "Jonas", "jonas@gmail.com");
            var c3 = new Client(3, "Lario", "Lario@gmail.com");

            _context.AddRange(c1, c2, c3);
            _context.SaveChanges();

        }
    }
}
