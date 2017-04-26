using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace Common.Forms.Base
{
    public sealed class MLGroupBox : GroupBox
    {
        public new string Text
        {
            get { return base.Text; }
            set
            {
                if (DataHolder.DesignMode)
                    base.Text = value;
                else
                    base.Text = DataHolder.GetString(value);
            }
        }
        
        public MLGroupBox()
        {
            BackColor = Color.White;
        }
    }
}
