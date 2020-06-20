using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Treinando.Data;
using Treinando.Migrations;
using Treinando.Models;

namespace Treinando.Services
{
    public class CompanyService
    {
        private readonly TreinandoContext _context;

        public CompanyService(TreinandoContext context)
        {
            _context = context;
        }
        public List<Company> FindAll()
        {
            return _context.Company.ToList();
        }
        public void Insert(Company obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
