using System.Collections;
using System.Collections.Generic;

namespace CityBook.Models
{
    public class City:Entity
    {
        public string Name { get; set; }
        public string PhoneCode { get; set; }
        public ICollection<PhoneBook> PhonesNumbers { get; set; }
    }
}