namespace Bilforhandler
{
    public class ShowDealer
    {
        public void UploadDealer()
        {
            var dealer = new Person("Jason Carsick", "Center City Street 42");
            CreateCarStock(dealer);
            ViewDealerInfo(dealer);
            RemoveCar(dealer);
        }

        public void CreateCarStock(Person dealer)
        {
            Car car1 = new Car("Mercedes", "EF88923", 2010, 20000);
            dealer.AddCar(car1);
            Car car2 = new Car("Ford", "DG82433", 2012, 80000);
            dealer.AddCar(car2);
            Car car3 = new Car("Toyota", "SB77867", 2015, 50300);
            dealer.AddCar(car3);
        }

        public void RemoveCar(Person dealer)
        {
            dealer.RemoveCar("EF88923");
        }

        public void ViewDealerInfo(Person dealer)
        {
            Console.WriteLine($"Dealer: {dealer.GetName()}, adress: {dealer.GetAdress()}.\n");
            dealer.ShowDealerCars();
        }
    }
}
