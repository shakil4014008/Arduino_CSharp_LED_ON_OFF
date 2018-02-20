using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Arduino
{
    public partial class Form1 : Form
    {
        public SerialPort myport;

        public Form1()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM3";
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnOn.Enabled = true;
            btnOff.Enabled = false;

        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("HPin");
            btnOn.Enabled = false;
            btnOff.Enabled = true;

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            myport.WriteLine("LPin");
            btnOn.Enabled = true;
            btnOff.Enabled = false;

        }
    }
}
