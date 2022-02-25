using Helper.Shared.Data;
using Helper.Shared.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helper.Server.Controllers.Usuarios
{
    [ApiController]
    [Route("api/usuarios")] //Ruta por la cual el server va a buscar a nuestro controlador y buscar lo que necesita
    public class UsuariosController: ControllerBase
    {
        private readonly dbContext context;

        public UsuariosController(dbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<List<Usuario>> Get() //Equivale a un select de SQL
        {
            return context.Usuarios.ToList();
        }

        [HttpGet("{usuarioId:int}")]
        public async Task<ActionResult<Anuncio>> Get(int usuarioId)
        {
            var anuncio = await context.Anuncios.Where(x => x.UsuarioId == usuarioId).FirstOrDefaultAsync();
            if (anuncio == null)
            {
                return NotFound($"No existe anuncios del usuario ");
            }
            return anuncio;
        }

        [HttpPost]
        public ActionResult<Usuario> Post(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            return usuario;
        }
    }
}
