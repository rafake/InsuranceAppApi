using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceAppApi.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Insurance : ControllerBase
    {
        public int InsuranceId { get; set; }
        public string InsuranceName { get; set; }
        public string InsuranceCategory { get; set; }
        public string InsuranceCompany { get; set; }
        public string DateOfJoining { get; set; }
        public string DateOfEnd { get; set; }
        public string PhotoFileName { get; set; }
    }
}
