﻿using QuieroPizzas.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizzas.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripción = "Pizza 6 Quesos";

            var producto2 = new ProductoModel();
            producto2.Id = 1;
            producto2.Descripción = "Pizza 4 Estaciones";

            var producto3 = new ProductoModel();
            producto3.Id = 1;
            producto3.Descripción = "Pizza Jamón y Queso";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return View(listadeProductos);
        }
    }
}