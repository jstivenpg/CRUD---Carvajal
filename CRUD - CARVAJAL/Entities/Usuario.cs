using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD___CARVAJAL.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        public string Nombre { get; set; }
        [StringLength(15)]
        public string Apellido { get; set; }
        [StringLength(2)]
        public string TipoDeIdentificacion { get; set; }
        [StringLength(15)]
        public string NumeroDeIdentificacion { get; set; }
        [PasswordPropertyText]
        public string Contrasena { get; set; }
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        public static explicit operator int(Usuario v)
        {
            throw new NotImplementedException();
        }
        
    }
}
