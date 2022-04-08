using MyProject.CQRS.Data;
using MyProject.CQRS.Models;
using MyProject.CQRS.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Repositories
{
    public class DepartmentsCommandRepository : IDepartmentsCommandRepository
    {
        private readonly EFCoreDbContext context;
        public DepartmentsCommandRepository(EFCoreDbContext _context)
        {
            context = _context;
        }
        public async Task<JsonResponse> Delete(int id) //200
        {
            var obj = await context.Departments.FindAsync(id);
            if (obj == null)
            {
                return new JsonResponse() { IsSuccess = false, Message ="Record not found.", StatusCode = 404 };
            }

            context.Departments.Remove(obj);
            await context.SaveChangesAsync();

            return new JsonResponse() { IsSuccess = true, Message = "Record deleted successfully.", StatusCode = 200};
        }

        public async Task<JsonResponse> Insert(Departments obj)
        {
            context.Departments.Add(obj);
            await context.SaveChangesAsync();

            return new JsonResponse() { IsSuccess = true, Message = "Record saved successfully.", StatusCode = 200 };
        }

        public async Task<JsonResponse> Update(Departments obj)
        {
            context.Departments.Update(obj);
            await context.SaveChangesAsync();

            return new JsonResponse() { IsSuccess = true, Message = "Record updated successfully.", StatusCode = 200 };
        }
    }
}
