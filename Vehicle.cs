namespace Lab1
{
    public abstract class Vehicle
    {
        protected int MaxPassengers;
        protected List<string> Passengers = new List<string>();
        protected Driver? Driver;

        public bool AssignDriver(Driver driver)
        {
            if (Driver != null)
            {
                Console.WriteLine("Водитель уже назначен!");
                return false;
            }
            Driver = driver;
            Console.WriteLine($"Водитель с категорией {driver.GetCategory()} назначен.");
            return true;
        }

        public bool AddPassenger(string passengerName)
        {
            if (Passengers.Count >= MaxPassengers)
            {
                Console.WriteLine($"Нет мест! Максимум: {MaxPassengers}");
                return false;
            }
            Passengers.Add(passengerName);
            Console.WriteLine($"Пассажир {passengerName} добавлен.");
            return true;
        }

        public bool IsReadyToDepart()
        {
            return Driver != null && Passengers.Count > 0;
        }

        public void Depart()
        {
            if (IsReadyToDepart())
            {
                Console.WriteLine($"Транспорт отправляется с {Passengers.Count} пассажирами!");
            }
            else
            {
                Console.WriteLine("Транспорт не готов к отправлению.");
            }
        }
    }

    public class Taxi : Vehicle
    {
        public Taxi()
        {
            MaxPassengers = 4;
        }
    }

    public class Bus : Vehicle
    {
        public Bus()
        {
            MaxPassengers = 30;
        }
    }
}