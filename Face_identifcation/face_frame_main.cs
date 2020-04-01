using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face_identifcation
{
    public partial class face_frame_main : Form
    {
        public face_frame_main()
        {
            InitializeComponent();
        }

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            XtraForm_configuration frm = new XtraForm_configuration();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void employeeFaceFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraForm_face_frame frm = new XtraForm_face_frame();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
