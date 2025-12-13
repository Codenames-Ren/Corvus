using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corvus.Data;
using Corvus.Models;

namespace Corvus.Services
{
    public class ExchangeServices
    {
        private readonly AppDbContext _db;

        public ExchangeServices(AppDbContext db)
        {
            _db = db;
        }

        public async Task save(Exchange exchange)
        {
            _db.Exchanges.Add(exchange);
            await _db.SaveChangesAsync();
        }
    }
}
