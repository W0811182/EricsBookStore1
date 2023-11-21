using EricsBooks.DataAccess.Repository.IRepository;
using EricsBooks.Models;
using EricsBookStore1.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EricsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            //use .NET LINQ to retrieve first or default cat obj
            //then pass id as generic entity which matchs cat ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = covertype.Name;

            }
        }
    }
}
