using CityBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBook.DataAccesss
{
    public class DataInitializer:DropCreateDatabaseAlways<DataContext>
    {
        private List<City> cities;
        public DataInitializer()
        {
            cities = new List<City>
            {
                new City
                {
                    Name = "Актау",
                    PhoneCode = "+7(7292)"
                },
                new City
                {
                    Name = "Алматы",
                    PhoneCode = "+7(7273)"
                },
                new City
                {
                    Name = "Нур-Султан",
                    PhoneCode = "+7(7172)"
                },
                new City
                {
                    Name = "Жезказган",
                    PhoneCode = "+7(7102)"
                },
                new City
                {
                    Name = "Караганда",
                    PhoneCode = "+7(7212)"
                },
                new City
                {
                    Name = "Кокшетау",
                    PhoneCode = "+7(71622)"
                },
                new City
                {
                    Name = "Костанай",
                    PhoneCode = "+7(7142)"
                },
                new City
                {
                    Name = "Павлодар",
                    PhoneCode = "+7(7182)"
                },
                new City
                {
                    Name = "Петропавловск",
                    PhoneCode = "+7(7152)"
                },
                new City
                {
                    Name = "Семей",
                    PhoneCode = "+7(7222)"
                },
                new City
                {
                    Name = "Талдыкорган",
                    PhoneCode = "+7(72822)"
                },
                new City
                {
                    Name = "Тараз",
                    PhoneCode = "+7(72622)"
                },
                new City
                {
                    Name = "Уральск",
                    PhoneCode = "+7(71122)"
                },
                new City
                {
                    Name = "Усть-Каменогорск",
                    PhoneCode = "+7(7232)"
                },
                new City
                {
                    Name = "Шымкент",
                    PhoneCode = "+7(7252)"
                }
            };
        }
        protected override void Seed(DataContext context)
        {
            context.Cities.AddRange(cities);
            base.Seed(context);
        }
    }
}
