using Projeto.Service;
using Projeto.VO;
using Projeto.DAO;
using Projeto.Model;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasPessoaGruposController : BaseRoutes<PessoaGrupo, PessoaGrupoVO, DataBaseContext, AutoMapperProfile, PessoaGrupoDAO, PessoaGrupoService>
    {
        
    }
}
