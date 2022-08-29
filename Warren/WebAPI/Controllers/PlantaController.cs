using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    public class PlantaController : GenericController<Planta, PlantaRepository>
    {
        public PlantaController() : base(new PlantaRepository())
        {

        }
    }
}
