using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Shared.Data.Entidades
{
    [Index(nameof(Tipo))]
    public class Anuncio
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Campo Obligatorio")]
        public int Tipo { get; set; }

        public string Tamano { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string ColorRGB1 { get; set; }
        public string ColorRGB2 { get; set; }
        public string Especie { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime FechaSuceso { get; set; }
        public DateTime FechaAnuncio { get; set; }
        public string FotoRuta { get; set; }
        public int UsuarioId { get; set; }
        //public Usuario Usuario { get; set; }
    }
}
