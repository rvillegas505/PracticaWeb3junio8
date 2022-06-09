using PracticaWeb3junio8.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticaWeb3junio8.Repositorios
{
    public class AnimalRepositorio
    {
        private _20221CPracticaEFContext _ctx;

        public AnimalRepositorio(_20221CPracticaEFContext ctx) { 

            _ctx = ctx;
        
        }

        public List<Animal> ObtenerTodos()
        {
            return _ctx.Animals.ToList();
        }
    }
}
