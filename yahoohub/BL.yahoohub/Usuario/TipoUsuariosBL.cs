using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
    public class TipoUsuariosBL
    {
        Contexto _contexto;
        public BindingList<TipoUsuario> ListaTipoUsuarios { get; set; }

        public TipoUsuariosBL()
        {
            _contexto = new Contexto();
            ListaTipoUsuarios = new BindingList<TipoUsuario>();
        }

        public BindingList<TipoUsuario> ObtenerTipoUsuarios()
        {
            _contexto.TipoUsuarios.Load();

            ListaTipoUsuarios = _contexto.TipoUsuarios.Local.ToBindingList();
            return ListaTipoUsuarios;
        }
    }

    public class TipoUsuario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}