using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace WinFormsApp1
{
    public partial class Bin : Form
    {
        public Bin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            t.add(mainFram, "Left", 300);
            t.run();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
