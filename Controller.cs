using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MDI_MultFormEvent
{
    internal class Controller : INotifyPropertyChanged, IControllerChanged
    {

        #region Public events

        public event EventHandler<ControllerEventArgs> ControllerChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        private bool button1Enabled;
        private bool button2Enabled;
        private bool button3Enabled;
        private bool button4Enabled;
        private bool checkbox1Checked;
        private bool checkbox2Checked;

        public bool Button1Enabled
        {
            get { return this.button1Enabled; }
            set
            {
                if (this.button1Enabled == value) return;
                this.button1Enabled = value;
                this.NotifyChange(ControlledItem.Button1);
            }
        }

        public bool Button2Enabled
        {
            get { return this.button2Enabled; }
            set
            {
                if (this.button2Enabled == value) return;
                this.button2Enabled = value;
                this.Checkbox2Checked = value;
                this.NotifyChange(ControlledItem.Button2);
            }
        }

        public bool Button3Enabled
        {
            get { return this.button3Enabled; }
            set
            {
                if (this.button3Enabled == value) return;
                this.button3Enabled = value;
                this.NotifyChange(ControlledItem.Button3);
            }
        }

        public bool Button4Enabled
        {
            get { return this.button4Enabled; }
            set
            {
                if (this.button4Enabled == value) return;
                this.button4Enabled = value;
                this.Checkbox1Checked = value;
                this.NotifyChange(ControlledItem.Button4);
            }
        }

        public bool Checkbox1Checked
        {
            get { return this.checkbox1Checked; }
            set
            {
                if (this.checkbox1Checked == value) return;
                this.checkbox1Checked = value;
                this.Button4Enabled = value;
                this.NotifyChange(ControlledItem.CheckBox1);
            }
        }

        public bool Checkbox2Checked
        {
            get { return this.checkbox2Checked; }
            set
            {
                if (this.checkbox2Checked == value) return;
                this.checkbox2Checked = value;
                this.Button2Enabled = value;
                this.NotifyChange(ControlledItem.CheckBox2);
            }
        }

        #endregion

        #region Main body

        public Controller()
        {
            this.Button1Enabled = true;
            this.Button2Enabled = true;
            this.Button3Enabled = true;
            this.Button4Enabled = true;
        }

        private void NotifyChange(ControlledItem item, [CallerMemberName]string propertyName = "")
        {
            this.OnControllerChanged(item);
            this.OnPropertyChanged(propertyName);
        }

        public virtual void OnControllerChanged(ControlledItem item)
        {
            if (this.ControllerChanged != null)
                this.ControllerChanged(this, new ControllerEventArgs(item));
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
