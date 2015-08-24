using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDI_MultFormEvent
{
    internal interface IControllerChanged
    {

        event EventHandler<ControllerEventArgs> ControllerChanged;

    }
}
