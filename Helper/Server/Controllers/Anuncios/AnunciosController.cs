using Helper.Shared.Data;
using Helper.Shared.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helper.Server.Controllers.Anuncios
{
    [ApiController]
    [Route("api/anuncios")] //Ruta por la cual el server va a buscar a nuestro controlador y buscar lo que necesita
    public class AnunciosController: ControllerBase
    {
        private readonly dbContext context;

        public AnunciosController(dbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<List<Anuncio>> Get() //Equivale a un select de SQL
        {
            return context.Anuncios.ToList();
        }
        [HttpGet("{usuarioId:int}")]
        public ActionResult<Anuncio> Get(int usuarioId)
        {
            var anuncio = context.Anuncios.Where(x => x.UsuarioId == usuarioId ).FirstOrDefault();
            if (anuncio == null)
            {
                return NotFound($"No existe anuncios del usuario ");
            }
            return anuncio;
        }
        [HttpPost]
        public ActionResult<Anuncio> Post(Anuncio anuncio)
        {
            context.Anuncios.Add(anuncio);
            context.SaveChanges();
            return anuncio;
        }

        [HttpPut("{Id:int}")]

        public ActionResult Put(int id,[FromBody]Anuncio anuncio)
        {
            if (id != anuncio.Id)
            {
                return BadRequest("Datos incorrectos");
            }
            var anunciomod = context.Anuncios.Where(x => x.Id == id).FirstOrDefault();
            if (anunciomod == null)
            {

            }
            try
            {
                context.Anuncios.Update(anunciomod);
                context.SaveChanges();
                return Ok("Modificado con exito");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
