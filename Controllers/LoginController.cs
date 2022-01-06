using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TesteIndra.Services;
using TesteIndra.Models;
using System.Threading.Tasks;
using TesteIndra.Database;
using Microsoft.EntityFrameworkCore;


namespace selecao_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromServices] AppDbContext context, [FromBody] LoginService model)
        {
            var studentExist = await context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == model.Email && x.Password == model.Password);

            if (studentExist == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }
            else
            {
                var token = TokenService.GenerateToken(studentExist);
                studentExist.Password = "";

                return new
                {
                    token = token
                };
            }
        }

    }
}