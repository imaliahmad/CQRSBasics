using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CQRS.Repositories.interfaces
{
    public interface IDepartmentsCommandRepository
    {
        //Commands --> Writing --> Insert, Update, Delete
        //Queries --> GetAll, GetById

        Task<JsonResponse> Insert(Departments obj);
        Task<JsonResponse> Update(Departments obj);
        Task<JsonResponse>  Delete(int id);
    }
}
