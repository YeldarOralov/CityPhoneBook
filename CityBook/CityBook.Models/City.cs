﻿using System.Collections;
using System.Collections.Generic;

namespace CityBook.Models
{
    public class City:Entity
    {
        public string Name { get; set; }
        public string PhoneCode { get; set; }
        public virtual ICollection<PhoneBook> PhonesNumbers { get; set; }
        public City()
        {
            PhonesNumbers = new List<PhoneBook>();
        }
    }
}