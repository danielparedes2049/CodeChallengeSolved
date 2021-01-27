using CodeChallenge.Data.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallengeTest
{
    public class Tests
    {
        private List<Animal> _animales;

        [SetUp]
        public void Setup()
        {
            _animales = new List<Animal>();
        }

        [Test]
        public void CalcularAlimentoSinAnimales()
        {
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CalcularAlimentoSoloCarnívoros()
        {
            _animales.AddRange(MockFactoryCarnívoros());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(result, 22.5);
        }

        [Test]
        public void CalcularAlimentoSoloHerviboros()
        {
            _animales.AddRange(MockFactoryHerbivoros());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(result, 185);
        }

        [Test]
        public void CalcularAlimentoSoloReptiles()
        {
            _animales.AddRange(MockFactoryReptiles());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void CalcularAlimentoTodos()
        {
            _animales.AddRange(MockFactoryTodos());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(result, 208.5);
        }

        #region Mock Factory
        private List<Animal> MockFactoryCarnívoros()
        {
            return new List<Animal>() {
                new Animal{
                    Tipo = AnimalType.Carnívoro.ToString(),
                    Peso = 100,
                    Porcentaje = 0.05
                },
                new Animal{
                    Tipo = AnimalType.Carnívoro.ToString(),
                    Peso = 80,
                    Porcentaje = 0.1
                },
                new Animal{
                    Tipo = AnimalType.Carnívoro.ToString(),
                    Peso = 95,
                    Porcentaje = 0.1
                }
            };
        }

        private List<Animal> MockFactoryHerbivoros()
        {
            return new List<Animal>() {
                new Animal{
                    Tipo = AnimalType.Herbívoro.ToString(),
                    Peso = 30,
                    Kilos = 10
                },
                new Animal{
                    Tipo = AnimalType.Herbívoro.ToString(),
                    Peso = 50,
                    Kilos = 15
                }
            };
        }

        private List<Animal> MockFactoryReptiles()
        {
            return new List<Animal>() {
                new Animal{
                    Tipo = AnimalType.Reptil.ToString(),
                    Peso = 21,
                    Kilos = 9,
                    Porcentaje = 0.1
                },
                new Animal{
                    Tipo = AnimalType.Reptil.ToString(),
                    Peso = 14,
                    Kilos = 11,
                    Porcentaje = 0.1
                }
            };
        }

        private List<Animal> MockFactoryTodos()
        {
            return new List<Animal>() {
                new Animal{
                    Tipo = AnimalType.Carnívoro.ToString(),
                    Peso = 100,
                    Porcentaje = 0.05
                },
                new Animal{
                    Tipo = AnimalType.Carnívoro.ToString(),
                    Peso = 80,
                    Porcentaje = 0.1
                },
                new Animal{
                    Tipo = AnimalType.Carnívoro.ToString(),
                    Peso = 95,
                    Porcentaje = 0.1
                },
                new Animal{
                    Tipo = AnimalType.Herbívoro.ToString(),
                    Peso = 30,
                    Kilos = 10
                },
                new Animal{
                    Tipo = AnimalType.Herbívoro.ToString(),
                    Peso = 50,
                    Kilos = 15
                },
                new Animal{
                    Tipo = AnimalType.Reptil.ToString(),
                    Peso = 21,
                    Kilos = 9,
                    Porcentaje = 0.1
                },
                new Animal{
                    Tipo = AnimalType.Reptil.ToString(),
                    Peso = 14,
                    Kilos = 11,
                    Porcentaje = 0.1
                }
            };
        }
        #endregion
    }
}