using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDI_MultFormEvent
{
    internal class ControllerEventArgs : EventArgs
    {

        public ControlledItem Item { get; private set; }

        public ControllerEventArgs(ControlledItem item)
        {
            this.Item = item;
        }

    }
}
