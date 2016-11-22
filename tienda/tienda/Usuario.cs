using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tienda
{
    
    public class Usuario
    {
        [Key] 

        public int Id { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// correo
        /// </summary>
        public string Correo { get; set; }
        /// <summary>
        /// Contraseña
        /// </summary>
        public string Contraseña { get; set; }
        /// <summary> 
        ///   TipodeUsuario 
        /// </summary>
        public string TipodeUsuario { get; set; }

    }
}