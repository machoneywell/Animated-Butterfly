using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animated
{
    public partial class Animated : Form
    {
        public Animated()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label.Text = "Monarch Butterflies start migrating South in September";
            label.Location = new Point(130, 390);
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label.Text = "Adult Monarch Butterflies live for 4-6 weeks";
            label.Location = new Point(185, 390);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label.Text = "This is a Monarch Butterfly";
            label.Location = new Point(265, 390);
        }
    }
}
