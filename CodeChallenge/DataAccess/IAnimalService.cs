using CodeChallenge.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.DataAccess
{
    public interface IAnimalService
    {
        Task<IEnumerable<Animal>> GetAllAnimals();
        Task<bool> InsertAnimal(Animal animal);
        Task<bool> DeleteAnimal(int id);
    }
}
