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
using Microsoft.VisualBasic.Logging;
using Model;

namespace WinForms
{
    public partial class ColorForm : Form
    {
        private readonly Logic logica;
        public ColorForm(Logic logic)
        {
            InitializeComponent();
            logica = logic;
        }

        private void searchColorButton_Click(object sender, EventArgs e)
        {
            string color = colorTextBox.Text.Trim();
            List<Car> foundCars = logica.FindCarByColor(color);

            if (foundCars.Count == 0)
            {
                MessageBox.Show("Автомобили с таким цветом не найдены.");
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
                // Добавьте информацию о каждом автомобиле в ListBox
                CarList.Items.Add($"ID: {car.Id}, Марка: {car.Brand}, Цвет: {car.Color}, Год: {car.Year}");
            }
        }

        private void exButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
