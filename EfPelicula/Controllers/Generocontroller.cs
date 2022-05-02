using EfPelicula.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EfPelicula.Controllers
{
    [ApiController]
    [Route("api/genero")]
    public class Generocontroller : ControllerBase
    {
        private readonly AppDbContext context;

        public Generocontroller(AppDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Genero> listar()
    }
}
