using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Helper.Shared.Data.Entidades
{
    [Index(nameof(Tipo))]
    public class Anuncio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "¿En que estado se encuentra?")]
        public int Tipo { get; set; } //1: Perdido, 2:En adopcion, 3: Encontrado
        
        public string Estado { get; set; }//1: Perdido, 2:En adopcion, 3: Encontrado
        [Required(ErrorMessage = "El nombre es obligatorio (asi podemos conocer mejor a nuestro amiga/o)")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Nombre { get; set; }
        public string Tamano { get; set; }
        [Required(ErrorMessage = "Este color es obligatorio")]
        public string ColorRGB1 { get; set; }
        public string ColorRGB2 { get; set; }
        [Required(ErrorMessage = "¿Qué especie es? Por favor, completa el campo :)")]
        [MaxLength(30, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Especie { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime FechaSuceso { get; set; }
        public DateTime FechaAnuncio { get; set; }
        public string RutaFoto { get; set; }
        public byte[] Foto { get; set; }
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria (asi podemos conocer mejor a nuestro amiga/o)")]
        [MaxLength(200, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Descripcion { get; set; }
        //public Usuario Usuario { get; set; }

        
    }
    
}
