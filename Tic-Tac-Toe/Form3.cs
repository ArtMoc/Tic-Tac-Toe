using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Donats : Form
    {
        public Donats()
        {
            InitializeComponent();
        }

        private void Donats_Load(object sender, EventArgs e)
        {
            label1.Text = "Не пожалейте на шоколадку :-)\n" + "5469770054856985258";
        }
    }
}
