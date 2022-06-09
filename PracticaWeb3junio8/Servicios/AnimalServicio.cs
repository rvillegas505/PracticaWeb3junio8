using PracticaWeb3junio8.Models;
using PracticaWeb3junio8.Repositorios;
using System.Collections.Generic;

namespace PracticaWeb3junio8.Servicios
{
    public class AnimalServicio
    {
        private AnimalRepositorio _animalRepo;
        public AnimalServicio(AnimalRepositorio animalRepo){

            _animalRepo = animalRepo;

        }

        public List<Animal> ObtenerTodos()
        {
         return _animalRepo.ObtenerTodos(); 
        }
    } 
}
