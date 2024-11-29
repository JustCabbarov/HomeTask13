namespace HomeTask12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Paris", 300, 5);
            Room room2 = new Room("Madrid", 200, 3);

            Hotel hotel = new Hotel("Hilton");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            
            Room wantedRoom = null;
            try
            {
                wantedRoom = hotel.MAkeREservation(1);
            }
            catch (NullReferenceException ex)

            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Bilinmeyen Xeta: {ex.Message} ");
            }

        }
    }
}
