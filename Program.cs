using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Контроль транспорта ===\n");

            // Создаем такси через фабрику
            VehicleFactory taxiFactory = new TaxiFactory();
            Vehicle taxi = taxiFactory.CreateVehicle();
            Driver taxiDriver = taxiFactory.CreateDriver();

            taxi.AssignDriver(taxiDriver);
            taxi.AddPassenger("Иван");
            taxi.AddPassenger("Мария");
            taxi.Depart();

            Console.WriteLine();

            // Создаем автобус через фабрику
            VehicleFactory busFactory = new BusFactory();
            Vehicle bus = busFactory.CreateVehicle();
            Driver busDriver = busFactory.CreateDriver();

            bus.AssignDriver(busDriver);
            for (int i = 1; i <= 25; i++) bus.AddPassenger($"Пассажир {i}");
            bus.Depart();

            // Проверяем Singleton
            Console.WriteLine("\n=== Проверка Singleton ===");
            Driver anotherTaxiDriver = TaxiDriver.Instance;
            Console.WriteLine($"Это тот же водитель такси? {taxiDriver == anotherTaxiDriver}");

            Driver anotherBusDriver = BusDriver.Instance;
            Console.WriteLine($"Это тот же водитель автобуса? {busDriver == anotherBusDriver}");
        }
    }
}