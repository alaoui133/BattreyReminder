using System;
using System.Management;
using System.Windows.Forms;

namespace BattryReminder
{
    public partial class Form1 : Form
    {
        String strBatteryChargingStatus;
        String strBatterylife;
        float batteryLife;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            // Create a new timer and set the interval in (milliseconds)
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000;

            // Add an event handler for the tick event
            timer.Tick += new EventHandler(Timer_Tick);

            // Start the timer
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Runing...";
            CheckBatteryStatus();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            refreshLabel();
        }


        private void refreshLabel()
        {
            battreyLifeLabel.Text = "Battery Life : " + Convert.ToInt32(batteryLife).ToString() + "%";

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Check Battery Status and show reminder
            CheckBatteryStatus();
        }

        private void CheckBatteryStatus()
        {

            // PowerStatus Indicate Current System Power Status

            PowerStatus pwr = SystemInformation.PowerStatus;

            // Get the battery status (high/low/....) using PowerStatus

            strBatteryChargingStatus = pwr.BatteryChargeStatus.ToString();

            // Get the battery life (%) using PowerStatus

            strBatterylife = pwr.BatteryLifePercent.ToString();

            batteryLife = float.Parse(strBatterylife.ToString()) * 100;

            if (Convert.ToInt32(batteryLife) == 100)
            {
                // If the battery is fully charged, show a reminder

                MessageBox.Show("The battery is fully charged! Please Unplug the charger", "Battery Reminder",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(batteryLife) <= 20)
            {
                // If the battery is 20% or less , show a reminder

                MessageBox.Show("The battery is Low Please Plug the charger!", "Battery Reminder",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            refreshLabel();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button1.Text = "Start";
            CloseFrom();

        }

        // to close the app
        private void CloseFrom()
        {
            if (MessageBox.Show(" Program closed ! \n Do you want to close the application?",
                "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}




