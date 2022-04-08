using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.API.DTOs.Requests
{
    public class DepartmentDTO
    {
        public int DeptId { get; set; }
        public string DName { get; set; }

        public static Departments ToDepartmentModel(DepartmentDTO departmentDTO)
        {
            return new Departments()
            {
                DeptId = departmentDTO.DeptId,
                DName = departmentDTO.DName
            };
        }

        public static DepartmentDTO ToDepartmentDTO(Departments model)
        {
            return new DepartmentDTO()
            {
                DeptId = model.DeptId,
                DName = model.DName
            };
        }
    }
}
