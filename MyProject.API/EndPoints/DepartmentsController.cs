using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.DTOs.Requests;
using MyProject.API.DTOs.Response;
using MyProject.CQRS.Commands.interfaces;
using MyProject.CQRS.Queries.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.API.EndPoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentsCommands deptCommands;
        private readonly IDepartmentsQueries deptQueries;
        public DepartmentsController(IDepartmentsCommands _deptCommands, IDepartmentsQueries _deptQueries) 
        {
            deptQueries = _deptQueries;
            deptCommands = _deptCommands;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response =await deptQueries.GetAll();
                var responseDTO = JsonResponseDTO.ToJsonResponseDTO(response);
                return Ok(responseDTO);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return BadRequest(new JsonResponseDTO() { IsSuccess = false, Message = msg, StatusCode = 500 });

            }
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            try
            {
                var response = await deptQueries.GetById(id);
                var responseDTO = JsonResponseDTO.ToJsonResponseDTO(response); //convert into DTO
                return Ok(responseDTO);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return BadRequest(new JsonResponseDTO() { IsSuccess = false, Message = msg, StatusCode = 500 });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentDTO deptDTO)
        {
            try
            {
                if (deptDTO == null)
                {
                    return BadRequest();
                }

                var dept = DepartmentDTO.ToDepartmentModel(deptDTO); //convert into Model
                var response = await deptCommands.Insert(dept);
                var responseDTO = JsonResponseDTO.ToJsonResponseDTO(response); //convert into DTO 
                return Ok(responseDTO);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return BadRequest(msg);
            }
        }

    }
}
