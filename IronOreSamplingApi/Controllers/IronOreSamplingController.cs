using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace IronOreSamplingApi.Controllers
{
    [ApiController]
    [Route("api/samples")]
    public class IronOreSamplingController : ControllerBase
    {
        private static readonly string[] Samples = new[]
        {
            "Sample A", "Sample B"
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Samples;
        }
    }
}
