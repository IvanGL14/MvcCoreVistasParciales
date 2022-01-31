using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> coches;

        public CochesController()
        {
            this.coches = new List<Coche>
            {
                new Coche{IdCoche=1, Marca="Renault", Modelo="Megane",
                VelocidadMaxima=230},
                new Coche{IdCoche=2, Marca="Opel", Modelo="Astra",
                VelocidadMaxima=220},
                new Coche{IdCoche=3, Marca="Fiat", Modelo="500",
                VelocidadMaxima=185},
                new Coche{IdCoche=4, Marca="Alpine", Modelo="Nano",
                VelocidadMaxima=1000},
                new Coche{IdCoche=5, Marca="Seat", Modelo="Ibiza",
                VelocidadMaxima=200},
            };                
        }
        public IActionResult Index()
        {
            return View(this.coches);
        }

        //ESTA VISTA NO TENDRÁ NADA AL CARGAR, PERO EN SU INTERIOR CARGAREMOS VISTAS PARCIALES CON JQUERY
        //TENDREMOS UNA VISTA PARCIAL CON TODOS LOS COCHES
        public IActionResult PeticionAsincrona()
        {
            return View();
        }

        //NECESITAMOS UN MÉTODO QUE SERÁ LLAMADO MEDIANTE load() DE JQUERY
        //LOS METODOS IACTIONRESULT SIEMPRE DEVUELVEN PartialView

        public IActionResult _CochesPartial()
        {
            return PartialView("_CochesPartial", this.coches);
        }

        public IActionResult _CochesDetailsPartial(int idcoche)
        {
            Coche car = this.coches.SingleOrDefault(z => z.IdCoche == idcoche);
            return PartialView("_CochesDetailsPartial", car);
        }
    }
}
