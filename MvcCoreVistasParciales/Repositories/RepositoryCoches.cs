using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Repositories
{
    public class RepositoryCoches
    {
        private List<Coche> coches;

        public RepositoryCoches()
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

        public List<Coche> GetCoches()
        {
            return this.coches;
        }

        public Coche FindCoche(int idcoche)
        {
            Coche car = this.coches.SingleOrDefault(z => z.IdCoche == idcoche);
            return car;
        }
    }
}
