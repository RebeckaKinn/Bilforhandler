namespace Bilforhandler
{
    public class Car
    {
        private string _model { get; }
        private string _registration { get; }
        private int _year { get; }
        private int _km { get; set; }

        public Car(string model, string regNumb, int year, int kmDriven)
        {
            _model = model;
            _registration = regNumb;
            _year = year;
            _km = kmDriven;
        }

        public string GetModel()
        {
            return _model;
        }

        public string GetRegistration()
        {
            return _registration;
        }

        public int GetYear()
        {
            return _year;
        }

        public int GetKM()
        {
            return _km;
        }
    }
}
