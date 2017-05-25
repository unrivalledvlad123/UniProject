using Common;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework.Components;
using MetroFramework.Interfaces;

namespace Common.Forms.Base
{
    /// <summary>
    /// Multi-Language Button implementation	
    /// </summary>
    public class MLToolTp : MetroToolTip
    {
        public new void SetToolTip(Control control, string caption)
        {
            base.SetToolTip(control, DataHolder.DesignMode ? caption : DataHolder.GetString(caption));

            if (!(control is IMetroControl))
                return;
            foreach (Control control1 in (ArrangedElementCollection) control.Controls)
                this.SetToolTip(control1, caption);
        }

        public MLToolTp()
        {
        }


    }
}
