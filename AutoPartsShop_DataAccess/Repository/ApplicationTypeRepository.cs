﻿using AutoPartsShop_DataAccess.Repository.IRepository;
using AutoPartsShop_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop_DataAccess.Repository
{
    public class ApplicationTypeRepository : Repository<ApplicationType>, IApplicationTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ApplicationType obj)
        {
            var objFromDb = _db.Category.FirstOrDefault(u=>u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
            }
        }
    }
}
