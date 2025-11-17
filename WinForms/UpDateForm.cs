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
    public partial class UpDateForm : Form
    {
        private readonly Logic logica;
        
        
        public UpDateForm(Logic logic)
        {
            InitializeComponent();
            logica = logic;

        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            string inputId = idForChangeBox.Text;

            if (int.TryParse(inputId, out int id))
            {
                // Найдите автомобиль по ID
                Car selectedCar = logica.FindCarByID(id);

                if (selectedCar != null)
                {
                    // Откройте форму для редактирования автомобиля
                    ChangeForm changeForm = new ChangeForm(selectedCar, logica);
                    Show(changeForm);

                    // Закройте форму выбора автомобиля
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Автомобиль с таким ID не найден.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
