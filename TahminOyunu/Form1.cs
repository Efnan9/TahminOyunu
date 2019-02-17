using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tahmınet_Click(object sender, EventArgs e)
        {
            TahmınEt goster = new TahmınEt();
            goster.ShowDialog();
        }

        private void TahmınEttır_Click(object sender, EventArgs e)
        {
            TahmınEttır goster = new TahmınEttır();
            goster.ShowDialog();
        }
    }
}
