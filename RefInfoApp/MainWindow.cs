using System;
using System.Windows.Forms;

namespace RefInfoApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            HelpForm form = new HelpForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
