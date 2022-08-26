using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository animalRepo;

        public AnimalController()
        {
            this.animalRepo = new AnimalRepository();
        }

        [HttpGet]
        public List<Animal>Get()
        {
            return animalRepo.GetAll();
        }

        [HttpPost]
        public string Post(Animal model)
        {
            return animalRepo.Create(model);
        }
    }
}
