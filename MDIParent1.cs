using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_MultFormEvent
{
    internal partial class MDIParent1 : Form
    {
        private IControllerChanged controller;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void controller_ControllerChanged(object sender, ControllerEventArgs e)
        {
            this.toolStripStatusLabel.Text = string.Format("{0} has changed", e.Item);
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            Controller control = new Controller();
            this.controller = control;
            this.controller.ControllerChanged += controller_ControllerChanged;

            Form1 f1 = new Form1(control);
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f1);
            f1.Show();

            Form2 f2 = new Form2(control);
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f2);
            f2.Show();
        }
    }
}
