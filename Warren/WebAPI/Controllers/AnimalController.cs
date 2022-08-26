using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public Animal Get()
        {
            Animal animal = new Animal
            {
                Id = 1,
                Especie = "Cachorro",
                Nome = "Tobias",
                Peso = 10.5F
            };
            return animal;
        }

        [HttpPost]
        public string Post(Animal model)
        {
            AnimalRepository animalRepo = new AnimalRepository();
            return animalRepo.Create(model);
        }
    }
}
