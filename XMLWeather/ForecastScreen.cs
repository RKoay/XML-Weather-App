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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            conditionLabel1.Text = Form1.days[1].condition;
            if (Form1.days[1].precipitation == "rain")
            {
                Image image1 = Properties.Resources.rainy_weather2;
                pictureBox1.Image = image1;
            }
            else if (Form1.days[1].precipitation == "snow")
            {
                Image image2 = Properties.Resources.snowy_weather2;
                pictureBox1.Image = image2;
            }
            else
            {
                Image image3 = Properties.Resources.sunny_weather3;
                pictureBox1.Image = image3;
            }
            //Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.0") + " °C"
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.0") + " °C";
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.0") + " °C";

            date2.Text = Form1.days[2].date;
            conditionLabel2.Text = Form1.days[2].condition;
            if (Form1.days[2].precipitation == "rain")
            {
                Image image1 = Properties.Resources.rainy_weather2;
                pictureBox3.Image = image1;
            }
            else if (Form1.days[2].precipitation == "snow")
            {
                Image image2 = Properties.Resources.snowy_weather2;
                pictureBox3.Image = image2;
            }
            else
            {
                Image image3 = Properties.Resources.sunny_weather3;
                pictureBox3.Image = image3;
            }
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.0") + " °C";
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.0") + " °C";

            date3.Text = Form1.days[3].date;
            conditionLabel3.Text = Form1.days[3].condition;
            if (Form1.days[3].precipitation == "rain")
            {
                Image image1 = Properties.Resources.rainy_weather2;
                pictureBox2.Image = image1;
            }
            else if (Form1.days[3].precipitation == "snow")
            {
                Image image2 = Properties.Resources.snowy_weather2;
                pictureBox2.Image = image2;
            }
            else
            {
                Image image3 = Properties.Resources.sunny_weather3;
                pictureBox2.Image = image3;
            }
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.0") + " °C";
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.0") + " °C";

            date4.Text = Form1.days[4].date;
            conditionLabel4.Text = Form1.days[4].condition;
            if (Form1.days[4].precipitation == "rain")
            {
                Image image1 = Properties.Resources.rainy_weather2;
                pictureBox4.Image = image1;
            }
            else if (Form1.days[4].precipitation == "snow")
            {
                Image image2 = Properties.Resources.snowy_weather2;
                pictureBox4.Image = image2;
            }
            else
            {
                Image image3 = Properties.Resources.sunny_weather3;
                pictureBox4.Image = image3;
            }
            min4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("0.0") + " °C";
            max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("0.0") + " °C";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
        
    }
}
