using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Bob_s_Gym
{
    public partial class Form1 : Form
    {

        public DateTime dtp => DOBPicker.Value;
        public Form1()
        {
            InitializeComponent();
        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
