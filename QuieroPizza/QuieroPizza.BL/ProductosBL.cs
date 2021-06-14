using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        Contexto _contexto; //_ es global

        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL() //ctor
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }
        public List<Producto> ObtenerProductos()   //OBTENER PRODUCTOS DEBE SER PÚBLICO
        {

            ListadeProductos = _contexto.Productos.ToList(); //LISTADO DE LA BASE DE DATOS QUIEROPIZZADB.MDF 
            return ListadeProductos;
        }          
        }
    }

