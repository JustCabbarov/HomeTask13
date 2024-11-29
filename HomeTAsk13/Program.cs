namespace HomeTask13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
               Brand="Porsche",
               Model="911",
               Type=CarTypeEnum.Sport

            };

            Car car2 = new Car()
            { 
                Brand= "Ford",
                Model= "F150",
                Type = CarTypeEnum.SUV

            };

           
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
        }
    }
}
