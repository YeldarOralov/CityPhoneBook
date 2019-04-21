using CityBook.DataAccesss;
using CityBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBook
{
    public partial class ShowPhones : Form
    {
        BindingSource source = new BindingSource();
        public ShowPhones(string cityName)
        {
            InitializeComponent();
            using (var context = new DataContext())
            {
                var phones = new List<PhoneBook>();
                foreach (var city in context.Cities.ToList())
                {
                    if (city.Name == cityName)
                    {
                        source.DataSource = city.PhonesNumbers;
                    }
                }
            }
            phonesTable.DataSource = source;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
