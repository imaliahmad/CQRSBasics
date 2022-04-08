using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Queries.interfaces
{
    public interface IDepartmentsQueries
    {
        Task<JsonResponse> GetAll();
        Task<JsonResponse> GetById(int id);
    }
}
