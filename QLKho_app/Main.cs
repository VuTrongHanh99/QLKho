
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho_app
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void qLCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLoadMain.Controls.Clear();
            this.Refresh();
            QLCustomer objForm = new QLCustomer();
            objForm.TopLevel = false;
            pnlLoadMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            pnlLoadMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //full Screen
            FormBorderStyle  = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            TopMost=true;
            //Clear and Refresh lại panel
            pnlLoadMain.Controls.Clear();
            this.Refresh();
            QLCustomer objForm = new QLCustomer();
            objForm.TopLevel = false;
            pnlLoadMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            pnlLoadMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void qLUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLoadMain.Controls.Clear();
            this.Refresh();
            QLUnit objForm = new QLUnit();
            objForm.TopLevel = false;
            pnlLoadMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            pnlLoadMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLoadMain.Controls.Clear();
            this.Refresh();
            QLObject objForm = new QLObject();
            objForm.TopLevel = false;
            pnlLoadMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            pnlLoadMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLoadMain.Controls.Clear();
            this.Refresh();
                KhachHangReport objForm = new KhachHangReport();
                objForm.TopLevel = false;
                pnlLoadMain.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                pnlLoadMain.Controls.Add(objForm);
                objForm.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {

        }
    }
}
