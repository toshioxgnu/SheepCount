using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContarOrvejas
{
    public partial class Form1 : Form
    {
        int oveja = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cuentaoveja_Click(object sender, EventArgs e)
        {
            oveja++;

            totalOveja.Text = "Ovejas: " + oveja.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
