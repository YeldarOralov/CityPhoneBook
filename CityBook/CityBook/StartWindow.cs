using CityBook.DataAccesss;
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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            using (var context = new DataContext())
            {
                foreach (var city in context.Cities.ToList())
                {
                    citiesList.Items.Add($"{city.Name}");
                }
            }
            citiesList.SelectedIndex = citiesList.Items.IndexOf("Нур-Султан");
        }

        private void citiesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPhone_Click(object sender, EventArgs e)
        {
            var cityName = citiesList.SelectedItem.ToString();

            MessageBox.Show(cityName);
            Form.ActiveForm.Close();
        }

        private void showPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
