using ConsoleApp32.DAL;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext db = new AppDBContext();
            Console.WriteLine("otel adi daxil et");
            string a = Console.ReadLine();
            foreach (Hotel c in db.Hotels)
            {
                if(c.Name == a)
                {
                    Console.WriteLine("otaq nomresi daxil et");
                    int n = int.Parse(Console.ReadLine());
                    Room room = new Room()
                    {
                        No = n,
                        HotelId = c.Id
                    };
                    db.Rooms.Add(room);
                    
                }
                
            }
            db.SaveChanges();
        }
    }
}
