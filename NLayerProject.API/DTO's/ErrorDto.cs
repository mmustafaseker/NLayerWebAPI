using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.DTO_s
{
    public class ErrorDto
    {
        public ErrorDto()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
        public int Status { get; set; }
    }
}
