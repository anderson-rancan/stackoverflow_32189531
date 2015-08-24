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
    internal partial class Form2 : Form
    {

        private Controller controller;

        public Form2(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button3rd.DataBindings.Add("Enabled", this.controller, "Button3Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            this.button4th.DataBindings.Add("Enabled", this.controller, "Button4Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            this.checkBox2nd.DataBindings.Add("Checked", this.controller, "Checkbox2Checked", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button3rd_Click(object sender, EventArgs e)
        {
            this.controller.Button1Enabled = !this.controller.Button1Enabled;
        }
    }
}
