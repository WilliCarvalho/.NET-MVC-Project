using MVCStudyProject.Data;
using MVCStudyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCStudyProject.Services
{
    public class DepartmentService
    {
        private readonly MVCStudyProjectContext _context;

        public DepartmentService(MVCStudyProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
