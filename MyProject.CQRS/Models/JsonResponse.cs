using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.CQRS.Models
{
    public class JsonResponse
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public List<string> Error { get; set; }
    }
}
