using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class GreetingForm: Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            int sec = 3;
            t.Interval = 1000*sec;
            t.Tick += (s, args) =>
            {
                t.Stop();
                this.Close();
            };
            t.Start();
        }
    }
}
