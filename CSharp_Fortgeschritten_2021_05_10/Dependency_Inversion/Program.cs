using System;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //MockTest
            ICar mockCar = new MockCar();
            ICarService service = new CarService();
            service.RepairCar(mockCar); //Testobjekt wird verwendet

            ICar releaseCar = new Car();
            releaseCar.Brand = "Porsche";
            releaseCar.Modell = "911er";
            releaseCar.ConstructionYear = new DateTime(2020, 8, 23);
            service.RepairCar(releaseCar);
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode 
    
    public class BadCar //Programmierer A -> 5 Tage
    {
        public int Id { get; set; }
        public string  Modell { get; set; }
        public string Typ { get; set; }
        public DateTime ConstructYear { get; set; }
    }
    
    public class BadCarService//Programmierer B -> 3 Tage
    {
        public void RepairCar(BadCar car) //BadCar Objekt verwenden + alle abgeleiteten Klassen von BadCar
        {
            //Mach was
        }
    }
    #endregion


    #region GoodCode

    public interface ICar
    {
        string Brand { get; set; }
        string Modell { get; set; }
        DateTime ConstructionYear { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }

    public class Car : ICar // 5 Tage
    {
        public string Brand { get; set; }
        public string Modell { get; set; }
        public DateTime ConstructionYear { get; set; }
    }

    public class CarService : ICarService // 3 Tage
    {
        public void RepairCar(ICar car)
        {
            //Machwas
        }
    }

    public class MockCar : ICar
    {
        public string Brand { get; set; } = "VW";
        public string Modell { get; set; } = "POLO";
        public DateTime ConstructionYear { get; set; } = new DateTime.Now;
    }
    #endregion
}
