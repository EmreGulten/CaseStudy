using CaseStudy.Helper;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeGeneratorController : ControllerBase
    {
        [HttpGet]
        [Route("CreateCode")]
        public List<string> GetCode(int count)
        {
            List<string> codes = new List<string>();
            for (int i = 0; i < count; i++)
            {
                codes.Add(CodeGenerationHelper.CreateCode(i));
            }
            return codes;
        }
    }
}
