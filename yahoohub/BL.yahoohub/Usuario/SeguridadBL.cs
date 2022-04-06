using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class SeguridadBL
    {
    
    }
    public class Usuario
    {
        public int UsuarioId { get; set; }
        //SEGURIDAD
        public string NombUsuario { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public bool Activo { get; set; }
    }

    public class ResultadoUsuario
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
