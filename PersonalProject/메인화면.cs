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
    public partial class ShipReservation : Form
    {
        public ShipReservation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check ck = new Check();
            ck.Show();
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();
        }

       

        

        private void button3_Click(object sender, EventArgs e)
        {
            Resister Rs = new Resister();
            Rs.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ReDriving RD = new ReDriving();
            RD.Show();
        }

        private void 회원탈퇴ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewRegistrieren NR = new NewRegistrieren();
            NR.Show();
        }

        private void 항구등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroundRe frm = new GroundRe();
            frm.Show();
        }

        private void 섬등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslandRe frm = new IslandRe();
            frm.Show();
        }

        private void 배등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipRe frm = new ShipRe();
            frm.Show();
        }

        private void 운행등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            driveing frm = new driveing();
            frm.Show();
        }
    }
}
