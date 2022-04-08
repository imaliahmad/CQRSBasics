using Microsoft.EntityFrameworkCore;
using MyProject.CQRS.Data;
using MyProject.CQRS.Models;
using MyProject.CQRS.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Repositories
{
    public class DepartmentsQueriesRepository : IDepartmentsQueriesRepository
    {
        private readonly EFCoreDbContext context;
        public DepartmentsQueriesRepository(EFCoreDbContext _context)
        {
            context = _context;
        }
        public async Task<JsonResponse> GetAll()
        {
            var list = await context.Departments.ToListAsync();
            return new JsonResponse() { IsSuccess = true, StatusCode = 200, Data= list};
        }

        public async Task<JsonResponse> GetById(int id)
        {
            var obj = await context.Departments.FindAsync(id);
            if (obj == null)
            {
                return new JsonResponse() { IsSuccess = false, StatusCode = 404, Message = "Record Not Found."};
            }

            return new JsonResponse() { IsSuccess = true, StatusCode = 200, Data = obj };
        }
    }
}
