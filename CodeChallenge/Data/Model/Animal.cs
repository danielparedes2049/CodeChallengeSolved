using System;

namespace CodeChallenge.Data.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public string LugarOrigen { get; set; }
        public double Peso { get; set; }
        public double Porcentaje { get; set; }
        public double Kilos { get; set; }
        public int CambioPiel { get; set; }
        public double TotalCarneMes { get; set; }
        public double TotalHierbaMes { get; set; }

        public double CalcularAlimento()
        {
            var totalAlimentoDia = 0D;
            var totalCarnes = 0D;
            var totalHierbas = 0D;
            if (Enum.TryParse(Tipo, out AnimalType tipoAnimal))
            {
                switch (tipoAnimal)
                {
                    case AnimalType.Carnívoro:
                        totalAlimentoDia = totalAlimentoDia + (Peso * Porcentaje);
                        TotalCarneMes = totalAlimentoDia * 30;
                        break;
                    case AnimalType.Herbívoro:
                        totalAlimentoDia = totalAlimentoDia + ((Peso * 2) + Kilos);
                        TotalHierbaMes = totalAlimentoDia * 30;
                        break;
                    case AnimalType.Reptil:
                        double totalCarnePorDia = (totalCarnes + (Peso * Porcentaje)) / 7;
                        double totalHierbaPorDia = (totalHierbas + (Peso * Porcentaje)) / 7;
                        totalAlimentoDia = totalAlimentoDia + totalCarnePorDia + totalHierbaPorDia;
                        TotalCarneMes = totalCarnePorDia * DaysReptilEats(); ;
                        TotalHierbaMes = totalHierbaPorDia * DaysReptilEats(); ;
                        break;
                }
            }
            return totalAlimentoDia;
        }
        private int DaysReptilEats()
        {
            int totalReptilDays = 30 - (30 / (CambioPiel + 3)) * 3;
            return totalReptilDays;
        }
    }
    public enum AnimalType
    {
        Carnívoro,
        Herbívoro,
        Reptil
    }
}