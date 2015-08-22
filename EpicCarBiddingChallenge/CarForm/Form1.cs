using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpicCarBiddingChallenge;
using System.Windows.Forms;

namespace CarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFormWithCar();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveCarFromForm();
        }
        private void refreshTextBox_Click(object sender, EventArgs e)
        {
            PopulateFormWithCar();
        }
        void PopulateFormWithCar()
        {
            var service = new CarService();
            var car = service.GetCar();
            if (car == null)
                return;
            colorTextBox.Text = car.Color;
            makeTextBox.Text = car.Make;
            modelTextBox.Text = car.Model;
            yearTextBox.Text = car.Year.ToString();
        }

        void SaveCarFromForm()
        {
            var car = new Car();
            car.Color = colorTextBox.Text;
            car.Make = makeTextBox.Text;
            car.Model = modelTextBox.Text;
            int year;
            if (int.TryParse(yearTextBox.Text, out year))
                car.Year = year;
            var service = new CarService();
            service.SaveCar(car);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
