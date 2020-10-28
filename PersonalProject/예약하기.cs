using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalProject
{
    public partial class Resister : Form
    {
        public Resister()
        {
            InitializeComponent();
        }

        private void 예약하기_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            N_member Nm = new N_member();
            Nm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
