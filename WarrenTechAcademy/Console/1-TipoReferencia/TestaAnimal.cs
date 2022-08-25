using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaAnimal
    {
        public static void ExecutaAnimal()
        {
            Cachorro dog = new Cachorro("Cachorro", 25.5);
            Gato cat = new Gato("Gato", 10.5);

            BaseRepository<Animal> animalRepo = new BaseRepository<Animal>();

            animalRepo.Create(dog);
            animalRepo.Create(cat);

            List<Animal> animals = animalRepo.Read();

            foreach (var a in animals)
            {
                System.Console.WriteLine(a.Nome);
                System.Console.WriteLine(a.FazerSom());
            }

        }
    }
}
