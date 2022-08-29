using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebAPI.Controllers
{
    [ApiController]
    public class AnimalController : GenericController<Animal, AnimalRepository>
    {
        public AnimalController() : base(new AnimalRepository())
        {
            
        }      
    }
}
