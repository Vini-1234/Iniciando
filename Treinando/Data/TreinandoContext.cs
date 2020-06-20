using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Treinando.Models;

namespace Treinando.Data
{
    public class TreinandoContext : DbContext
    {
        public TreinandoContext (DbContextOptions<TreinandoContext> options)
            : base(options)
        {
        }

        public DbSet<Treinando.Models.Client> Client { get; set; }
    }
}
