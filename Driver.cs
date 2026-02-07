namespace Lab1
{
    public abstract class Driver
    {
        public abstract string GetCategory();
    }

    public class TaxiDriver : Driver
    {
        private static TaxiDriver? _instance;
        private static readonly object _lock = new object();

        private TaxiDriver() { }

        public static TaxiDriver Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new TaxiDriver();
                        }
                    }
                }
                return _instance;
            }
        }

        public override string GetCategory() => "B";
    }

    public class BusDriver : Driver
    {
        private static BusDriver? _instance;
        private static readonly object _lock = new object();

        private BusDriver() { }

        public static BusDriver Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BusDriver();
                        }
                    }
                }
                return _instance;
            }
        }

        public override string GetCategory() => "D";
    }
}