using MongoDB.Driver;

namespace MongoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
      IMongoClient client = new MongoClient("link");
      IMongoDatabase db = client.GetDatabase("db");

      
        }
    }
}
