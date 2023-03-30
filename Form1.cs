using System.Collections;

namespace Skrot
{
    public partial class Form1 : Form
    {
        Hashtable applications = new Hashtable();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Test
        }

        private void launcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // applications.Add("My EXE", "c:\\");
            int nextSlot = applicationsToolStripMenuItem.DropDownItems.Count;
            applicationsToolStripMenuItem.DropDownItems.Add("My EXE " + nextSlot);
            applicationsToolStripMenuItem.DropDownItems[nextSlot].Click += applicationsToolStripMenuItemLaunch_Click;
            launcherToolStripMenuItem.DropDownItems.Add("My EXE " + nextSlot);
            launcherToolStripMenuItem.DropDownItems[nextSlot].Click += launcherToolStripMenuItemEdit_Click;
        }

        private void applicationsToolStripMenuItemLaunch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LAUNCH " + sender.ToString());
        }
        private void launcherToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EDIT " + sender.ToString());
        }

    }
}