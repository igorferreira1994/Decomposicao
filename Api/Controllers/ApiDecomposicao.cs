using Decomposicao.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiDecomposicao
    {        

        public ApiDecomposicao()
        {
            
        }

        [HttpGet()]
        public Decompor ObterDados(int numero)
        {
            Decom decom = new Decom();
            Decompor decompor = new Decompor();
            decompor = decom.RetornoCalculoApi(numero);
            return decompor;
        }
    }
}
