using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinando.Models
{
    public class SalesRecord
    {
        public int SalesRecordId { get; set; }
        public double Price { get; set; }
        public DateTime SaleDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
