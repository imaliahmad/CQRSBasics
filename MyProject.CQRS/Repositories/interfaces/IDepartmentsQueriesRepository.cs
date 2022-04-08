using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Repositories.interfaces
{
    public interface IDepartmentsQueriesRepository
    {
        Task<JsonResponse> GetAll();
        Task<JsonResponse> GetById(int id);

    }
}
