using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
            MessageBox.Show("Ты прекрасна ВСЕГДА, этот тест обманка, чтобы привлечь твоё внимание!");
        }
            else
                this.progressBar1.Value += 1;
        }
    }
}
