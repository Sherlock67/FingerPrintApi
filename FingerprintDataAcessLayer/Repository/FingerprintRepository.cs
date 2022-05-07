
using FingerprintAPI.Data;
using FingerprintAPI.Model;
using FingerprintDataAcessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintDataAcessLayer.Repository
{
    public class FingerprintRepository : IFingerprintSave
    {
        private readonly ApplicationDbContext _db;
        public FingerprintRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<FingerPrint> Create(FingerPrint entity)
        {
            var obj = await _db.fingerprints.AddAsync(entity);
            _db.SaveChanges();
            return obj.Entity;
        }
    }
}
