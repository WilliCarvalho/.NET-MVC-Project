using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCStudyProject.Models;

namespace MVCStudyProject.Data
{
    public class MVCStudyProjectContext : DbContext
    {
        public MVCStudyProjectContext (DbContextOptions<MVCStudyProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MVCStudyProject.Models.Department> Department { get; set; }
    }
}
