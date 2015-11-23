using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem_ManageEvents_Click(object sender, EventArgs e)
        {
            Form_EventManagement form_EventManage = new Form_EventManagement();

            try
            {

                form_EventManage.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

                return;
            }

        }
    }
}
