using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tienda
{
    public class Producto
    {
        [Key]

        public int Id { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public string Precio { get; set; }
        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Foto
        /// </summary>
        public string Foto { get; set; }
        /// <summary>
        /// FechaSubida
        /// </summary>
        public DateTime FechaSubida { get; set; }
    }
}