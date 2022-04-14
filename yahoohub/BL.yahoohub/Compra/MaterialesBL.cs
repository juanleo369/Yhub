using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.yahoohub
{
   public class MaterialesBL
    {
        //Variable local de la base y Variable de la lista
        Contexto _contexto;

        public BindingList<Material> ListaMateriales { get; set; }

        //Codigo que sirve para hacer el llamado de la base de datos y inicializar listas.
        public MaterialesBL()
        {
            _contexto = new Contexto();
            ListaMateriales = new BindingList<Material>();

        }

        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Material> ObtenerMateriales()
        {
            _contexto.Materiales.Load();
            ListaMateriales = _contexto.Materiales.Local.ToBindingList();
            return ListaMateriales;
        }


        //Codigo que sirve para crear una lista de  datos y enviarla al form
        public BindingList<Material> ObtenerMateriales(int id)
        {
            _contexto.Materiales.FirstOrDefault( r => r.Id == id);
            ListaMateriales = _contexto.Materiales.Local.ToBindingList();
            return ListaMateriales;
        }

        //Codigo que sirve para Guardar datos en la base de datos
        public ResultadoMaterial GuardarMaterial(Material material)
        {
            var resultado = Validar(material);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        //Codigo que sirve para agregar datos en la base de datos
        public void AgregarMaterial()
        {
            var nuevoMateriales = new Material();
            ListaMateriales.Add(nuevoMateriales);
        }

        //Codigo que sirve para eliminar datos en la base de datos
        public bool EliminarMaterial(int id)
        {
            foreach (var material in ListaMateriales)
            {
                if (material.Id == id)
                {
                    ListaMateriales.Remove(material);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        //Codigo para validar los campos  que se desean guardar no esten vacios.
        private ResultadoMaterial Validar(Material material)
        {
            var resultado = new ResultadoMaterial();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(material.Nombre) == true)
            {
                resultado.Mensaje = "ingrese un material";
                resultado.Exitoso = false;

            }
            if (string.IsNullOrEmpty(material.Descripcion) == true)
            {
                resultado.Mensaje = "ingrese la Descripción";
                resultado.Exitoso = false;

            }

            if (material.PrecioUnit <= 0)
            {
                resultado.Mensaje = "ingrese el precio del material";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }

    //Codigo que sirve para crear la tabla y sus campos en la base de datos(Contexto)
    public class Material
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnit { get; set; }
        public int Stock { get; set; }


    }

    //Codigo que sirve para validar los campos que se ingresan
    public class ResultadoMaterial
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
