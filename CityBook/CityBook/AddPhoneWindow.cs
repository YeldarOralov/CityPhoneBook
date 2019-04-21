using CityBook.DataAccesss;
using CityBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBook
{
    public partial class AddPhoneWindow : Form
    {
        private string _cityName;
        public AddPhoneWindow(string cityName)
        {
            _cityName = cityName;
            InitializeComponent();
            string maskPhone="";
            using(var context = new DataContext())
            {
                foreach(var city in context.Cities.ToList())
                {
                    if (city.Name == cityName)
                    {
                        maskPhone = city.PhoneCode;
                    }
                }
            }
            enteredPhone.Mask = maskPhone+"000-000";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                foreach (var city in context.Cities.ToList())
                {
                    if (city.Name == _cityName)
                    {
                        city.PhonesNumbers.Add(new PhoneBook { FullName = enteredName.Text, Number = enteredPhone.Text });
                        context.SaveChanges();
                    }
                }
            }
            Form.ActiveForm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();

        }
    }
}
