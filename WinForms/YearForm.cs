using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Model;

namespace WinForms
{
    public partial class YearForm : Form
    {
        private readonly Logic logica;
        public YearForm(Logic logic)
        {
            InitializeComponent();
            logica=logic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string year = yearTextBox.Text.Trim();
            List<Car> foundCars = logica.FindCarByYear(year);

            if (foundCars.Count == 0)
            {
                MessageBox.Show("Автомобили с таким годом не найдены.");
            }
            else
            {
                DisplayCars(foundCars);
            }
        }
        private void DisplayCars(List<Car> cars)
        {
            CarList.Items.Clear();
            foreach (var car in cars)
            {                
                CarList.Items.Add($"ID: {car.Id}, Марка: {car.Brand}, Цвет: {car.Color}, Год: {car.Year}");
            }
        }

        private void exButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
