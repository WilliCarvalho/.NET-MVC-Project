﻿using MVCStudyProject.Data;
using MVCStudyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCStudyProject.Services
{
    public class SellerService
    {
        private readonly MVCStudyProjectContext _context;

        public SellerService(MVCStudyProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}