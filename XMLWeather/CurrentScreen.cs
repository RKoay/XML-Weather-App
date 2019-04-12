using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            if (Form1.days[0].condition == "sky is clear")
            {
                Image image1 = Properties.Resources.sunny_weather2;

                conditionLabel.Image = image1;
            }
            else if (Form1.days[0].condition == "moderate rain" || Form1.days[0].condition == "light snow")
            {
                Image image2 = Properties.Resources.rainy_weather;

                conditionLabel.Image = image2;
            }
            else
            {
                Image image3 = Properties.Resources.cloudy_weather;

                conditionLabel.Image = image3;
            }

            cityOutput.Text = Form1.days[0].location;
            dateLabel.Text = Form1.days[0].date;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.0") + " °C";
            minOutput.Text = Form1.days[0].tempLow + " °C";
            maxOutput.Text = Form1.days[0].tempHigh + " °C";
            conditionLabel.Text = Form1.days[0].condition;
        }

        

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
