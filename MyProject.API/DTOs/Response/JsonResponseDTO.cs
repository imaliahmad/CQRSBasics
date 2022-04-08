using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.API.DTOs.Response
{
    public class JsonResponseDTO
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public List<string> Error { get; set; }

        public static JsonResponse ToJsonResponseModel(JsonResponseDTO responseDTO)
        {
            return new JsonResponse()
            {
                IsSuccess = responseDTO.IsSuccess,
                Message = responseDTO.Message,
                StatusCode = responseDTO.StatusCode,
                Data = responseDTO.Data,
                Error = responseDTO.Error,
            };
        }
        public static JsonResponseDTO ToJsonResponseDTO(JsonResponse model)
        {
            return new JsonResponseDTO()
            {
                IsSuccess = model.IsSuccess,
                Message = model.Message,
                StatusCode = model.StatusCode,
                Data = model.Data,
                Error = model.Error,
            };
        }
    }
}
