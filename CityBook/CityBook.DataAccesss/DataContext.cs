using CityBook.Models;
using System.Data.Entity;
namespace CityBook.DataAccesss
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer<DataContext>(new DataInitializer());
        }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<PhoneBook> Phones { get; set; }

    }
}