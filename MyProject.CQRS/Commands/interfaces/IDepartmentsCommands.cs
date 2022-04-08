using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Commands.interfaces
{
    public interface IDepartmentsCommands
    {
        Task<JsonResponse> Insert(Departments obj);
        Task<JsonResponse> Update(Departments obj);
        Task<JsonResponse> Delete(int id);
    }
}
