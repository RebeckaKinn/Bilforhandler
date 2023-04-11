namespace Bilforhandler
{
    public class Person
    {
        private string _name { get; set; }
        private string _adress { get; set; }
        public List<Car> Cars { get; set; }

        public Person(string name, string adress)
        {
            _name = name;
            _adress = adress;
            Cars = new List<Car>();
        }

        public void AddCar(Car newCar)
        {
            Cars.Add(newCar);
        }

        public void RemoveCar(string regNumber)
        {
            foreach (Car car in Cars)
            {
                if (car.GetRegistration() == regNumber) Cars.Remove(car);
            }
        }

        public void ShowDealerCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car.GetModel()} {car.GetYear()}, {car.GetRegistration()}, KM: {car.GetKM()}");
            }
        }

        public void ShowOldCars(int year)
        {
            foreach (Car car in Cars)
            {
                if (car.GetYear() > year) Console.WriteLine($"{car.GetModel()} {car.GetYear()}, {car.GetRegistration()}, KM: {car.GetKM()}");
            }
        }

        public void ShowDrivenCars(int km)
        {
            foreach (Car car in Cars)
            {
                if (car.GetKM() > km) Console.WriteLine($"{car.GetModel()} {car.GetYear()}, {car.GetRegistration()}, KM: {car.GetKM()}");
            }
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAdress()
        {
            return _adress;
        }
    }
}
