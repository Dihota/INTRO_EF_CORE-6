using EfPelicula.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfPelicula.Controllers
{
    public class GeneroController :ControllerBase
    {
        private readonly AppDbContext context;

        public GeneroController(AppDbContext context)
        {
            this.context = context;
        }

        //Lista todos los registros
        [HttpGet("Listar")]
        public  List<Genero> Listar()
        {
           return context.Generos.ToList();
        }

        //Primer registro
        [HttpGet("Top_1")]
        public async Task<Genero> Top_1()
        {
            return await context.Generos.FirstAsync();
        }

        //Primer registro que comience por
        [HttpGet("Top_igual")]
        public async Task<Genero> Top_igual()
        {
            return await context.Generos.FirstAsync(g => g.Nombre.StartsWith("C"));
        }

        //Retornar con parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Genero>> Get(int id)
        {
            var genero = await context.Generos.FirstOrDefaultAsync(genero => genero.ID == id);

            if (genero is null)
            {
                return NotFound();
            }

            return genero;  
        }

        //Filtrando con Where
        [HttpGet("Filtrar")]
        public List<Genero> Filtrar(string nombre)
        {
            return context.Generos.Where(
                g => g.Nombre == nombre).ToList();   
        }

        //Filtrando con Where que contenga
        [HttpGet("Filtrar_Contenga")]
        public List<Genero> Filtrar_Contenga(string nombre)
        {
            return context.Generos.Where(
                g => g.Nombre.Contains(nombre)).ToList();
        }

        //Filrar y ordenar con where y order by
        [HttpGet("FiltrarOrdenar")]
        public List<Genero> FiltrarOrdenar(string nombre)
        {
            return context.Generos.Where(g => g.Nombre.Contains(nombre))
                .OrderBy(g => g.Nombre)
                .ToList();
        }

        //Filrar y ordenar con where y order by desendente
        [HttpGet("FiltrarOrdenarDesc")]
        public List<Genero> FiltrarOrdenarDesc(string nombre)
        {
            return context.Generos.Where(g => g.Nombre.Contains(nombre))
                .OrderByDescending(g => g.Nombre)
                .ToList();
        }

        //Proceso de paginacion con Skip y Take
        [HttpGet("Paginacion")]
        public async Task<ActionResult<IEnumerable<Genero>>> GetPaginacion(int pagina=1)
        {
            var CantidadRegistrosPorPagina = 2;
            var Generos = await context.Generos
                .Skip((pagina - 1) * CantidadRegistrosPorPagina)
                .Take(CantidadRegistrosPorPagina)
                .ToListAsync();

            return Generos;
        }
    }
}
