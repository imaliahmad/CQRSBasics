using MyProject.CQRS.Models;
using MyProject.CQRS.Queries.interfaces;
using MyProject.CQRS.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Queries
{
    public class DepartmentsQueries : IDepartmentsQueries
    {
        private readonly IDepartmentsQueriesRepository repository;
        public DepartmentsQueries(IDepartmentsQueriesRepository _repository)
        {
            repository = _repository;
        }
        public async Task<JsonResponse> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<JsonResponse> GetById(int id)
        {
            return await repository.GetById(id);
        }
    }
}
