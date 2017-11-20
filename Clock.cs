using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        /*
         * Update the labels on inital load
         */
        private void Clock_Load(object sender, EventArgs e)
        {
            updateTimeLabels();
        }

        /*
         * Update the labels every second
         */
        private void tmrTimeUpdater_Tick(object sender, EventArgs e)
        {
            updateTimeLabels();
        }

        /*
         * Update all the time labels to display the correct time
         */
        private void updateTimeLabels()
        {
            DateTime utcDate = DateTime.UtcNow; // Current UTC date

            lblUnixTime.Text = ((int)(utcDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
            lblAestTime.Text = TimeZoneInfo.ConvertTime(utcDate, TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time")).ToString("hh:mm tt, dd/MM/yyyy");
            lblGmtTime.Text = utcDate.ToString("hh:mm tt, dd/MM/yyyy");
        }
    }
}
