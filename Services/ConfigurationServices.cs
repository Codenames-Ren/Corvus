using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corvus.Data;
using Corvus.Models;
using Microsoft.EntityFrameworkCore;

namespace Corvus.Services
{
    public class ConfigurationServices
    {
        private readonly AppDbContext _db;
        public ConfigurationServices(AppDbContext db) => _db = db;

        public async Task<Configuration?> GetConfig()
        {
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            return config;
        }

        public async Task addOrUpdate(String terminologi1, String terminologi2, String terminologi3, Decimal exchangeRate, Decimal inhouseFee, Decimal acrossFee)
        {
            Boolean isNew = false;
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            if (config == null)
            {
                isNew = true;
                config = new Configuration();
            }

            config.terminologi1 = terminologi1;
            config.terminologi2 = terminologi2;
            config.terminolog3 = terminologi3;
            config.exchangeRate = exchangeRate;
            config.transferInhouseFee = inhouseFee;
            config.transferAcrossFee = acrossFee;

            if (isNew)
            {
                _db.Add(config);
            }
            else
            {
                _db.Update(config);
            }
            await _db.SaveChangesAsync();
        }

        public async Task Update(Configuration config)
        {
            _db.Configurations.Update(config);
            await _db.SaveChangesAsync();
        }
    }
}
