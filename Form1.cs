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
    internal partial class Form1 : Form
    {

        private Controller controller;

        public Form1(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1st.DataBindings.Add("Enabled", this.controller, "Button1Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            this.checkBox1st.DataBindings.Add("Checked", this.controller, "Checkbox1Checked", false, DataSourceUpdateMode.OnPropertyChanged);
            this.button2nd.DataBindings.Add("Enabled", this.controller, "Button2Enabled", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1st_Click(object sender, EventArgs e)
        {
            this.controller.Button3Enabled = !this.controller.Button3Enabled;
        }

    }
}
