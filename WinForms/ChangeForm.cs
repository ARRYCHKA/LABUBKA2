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
    public partial class ChangeForm : Form

    {
        private readonly Car selectedCar;
        private readonly Logic logica;
        public ChangeForm(Car car, Logic logic)
        {
            InitializeComponent();
            selectedCar = car;
            logica = logic;
            selectedCar.Brand = brandTextBox.Text;
            selectedCar.Color = colorTextBox.Text;
            selectedCar.Year = yearTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string newBrand = selectedCar.Brand;
                    string newColor = selectedCar.Color;
                    string newYear = selectedCar.Year;

                    logica.UpdateCars(selectedCar.Id, newBrand, newColor, newYear);
                    MessageBox.Show("Автомобиль успешно обновлён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
