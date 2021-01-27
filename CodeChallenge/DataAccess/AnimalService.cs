using CodeChallenge.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge.DataAccess
{
    public class AnimalService : IAnimalService
    {
        private readonly ApplicationDbContext _context;

        public AnimalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Animal>> GetAllAnimals()
        {
            return await _context.Animales.ToListAsync();
        }

        public async Task<bool> InsertAnimal(Animal animal)
        {
            _context.Animales.Add(animal);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAnimal(int id)
        {
            var animal = await _context.Animales.FindAsync(id);
            _context.Animales.Remove(animal);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
