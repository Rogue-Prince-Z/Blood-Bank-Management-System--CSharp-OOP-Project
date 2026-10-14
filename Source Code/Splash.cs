using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        private void Splash_Load(object sender, EventArgs e)
        {
            // Set the timer interval to 0.3 seconds)
            timer.Interval = 300;

            // Attach the Tick event handler to update the progress bar
            timer.Tick += Timer_Tick;

            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value + 10 <= progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }

            else
            {
                timer.Stop();
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }
    }
}