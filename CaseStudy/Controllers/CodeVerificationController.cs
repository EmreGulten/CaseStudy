using CaseStudy.Helper;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeVerificationController : ControllerBase
    {

        [HttpGet]
        [Route("VerifyCode")]
        public bool VerifyCode(string code)
        {
            return CodeVerificationHelper.VerifyCode(code);
        }
    }
}
