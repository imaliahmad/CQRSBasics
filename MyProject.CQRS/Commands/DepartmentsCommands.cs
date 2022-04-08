using MyProject.CQRS.Commands.interfaces;
using MyProject.CQRS.Models;
using MyProject.CQRS.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Commands
{
    public class DepartmentsCommands : IDepartmentsCommands
    {
        private readonly IDepartmentsCommandRepository repository;
        public DepartmentsCommands(IDepartmentsCommandRepository _repository)
        {
            repository = _repository;
        }
        public async Task<JsonResponse> Delete(int id)
        {
            return await repository.Delete(id);
        }

        public async Task<JsonResponse> Insert(Departments obj)
        {
            return await repository.Insert(obj);
        }

        public async Task<JsonResponse> Update(Departments obj)
        {
            return await repository.Update(obj);
        }
    }
}
