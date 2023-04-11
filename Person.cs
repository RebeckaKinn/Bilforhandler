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

        public List<Car> ShowDealerCars()
        {
            return Cars;
        }

        public List<Car> ShowOldCars(int year)
        {
            List<Car> OldCarsList = new List<Car>();
            foreach (Car car in Cars)
            {
                if (car.GetYear() > year) OldCarsList.Add(car);
            }
            return OldCarsList;
        }

        public List<Car> ShowDrivenCars(int km)
        {
            List<Car> HighKmCars = new List<Car>();
            foreach (Car car in Cars)
            {
                if (car.GetKM() > km) HighKmCars.Add(car);
            }
            return HighKmCars;
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
