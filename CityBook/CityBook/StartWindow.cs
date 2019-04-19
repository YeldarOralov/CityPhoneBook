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
                    comboBox1.Items.Add($"{city.Name}");
                }
            }
        }
    }
}
