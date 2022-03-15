using Helper.Shared.Data;
using Helper.Shared.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helper.Server.Controllers.Anuncios
{
    [ApiController]
    [Route("api/publicaciones")] //Ruta por la cual el server va a buscar a nuestro controlador y buscar lo que necesita
    public class AnunciosController: ControllerBase
    {
        private readonly dbContext context;

        public AnunciosController(dbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task <ActionResult<List<Anuncio>>> Get() //Equivale a un select de SQL
        {
            return await context.Anuncios.ToListAsync();
        }
        [HttpGet("{id:int}")]
        public async Task< ActionResult<Anuncio>> Get(int id)
        {
            var anuncio = await context.Anuncios.Where(x => x.Id == id ). FirstOrDefaultAsync();
            if (anuncio == null)
            {
                return NotFound($"No existe anuncios con ese Id ");
            }
            return anuncio;
        }
        [HttpGet("{animal=array}")]
        public async Task<ActionResult<List<Anuncio>>> Get(string animal) //Equivale a un select de SQL
        {
            return await context.Anuncios.Where(x => x.Especie == animal).ToListAsync();
            

        }
            
    


        [HttpPost]
        public async Task< ActionResult<Anuncio>> Post(Anuncio anuncio)
        {
          
            context.Anuncios.Add(anuncio);
            await context.SaveChangesAsync();
            return anuncio;
        }

        [HttpPut("{id:int}")]

        public async Task <ActionResult> Put(int id, [FromBody] Anuncio anuncio)
        {
            if (id != anuncio.Id)
            {
                return BadRequest("Datos incorrectos");
            }
            var anuncioAmod = await context.Anuncios.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (anuncioAmod == null)
            {
                return NotFound("No existe el anuncio a modificar");

            }
            anuncioAmod.Nombre = anuncio.Nombre;
            anuncioAmod.ColorRGB1 = anuncio.ColorRGB1;
            anuncioAmod.ColorRGB2 = anuncio.ColorRGB2;
            anuncioAmod.Especie = anuncio.Especie;
            anuncioAmod.FechaAnuncio = anuncio.FechaAnuncio;
            anuncioAmod.FechaSuceso = anuncio.FechaSuceso;
            anuncioAmod.RutaFoto = anuncio.RutaFoto;
            anuncioAmod.Foto = anuncio.Foto;
            anuncioAmod.Tamano = anuncio.Tamano;
            anuncioAmod.Tipo = anuncio.Tipo;
            anuncioAmod.Descripcion = anuncio.Descripcion;
            anuncioAmod.UsuarioId = anuncio.UsuarioId;
            anuncioAmod.Id = anuncio.Id;
            try
            {
                context.Anuncios.Update(anuncioAmod);
                await context.SaveChangesAsync();
                return Ok("Modificado con exito");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [HttpDelete("{id:int}")]
        public async Task< ActionResult> Delete(int id)
        {
            var anuncio = await context.Anuncios.Where(x => x.Id == id).FirstOrDefaultAsync();
            
            if (anuncio == null)
            {
                return NotFound($"No existe anuncios con id igual a {id}.");
            }

            try
            {
                context.Anuncios.Remove(anuncio);
                await context.SaveChangesAsync ();
                return Ok($"El anuncio de {anuncio.Nombre} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}
