using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Forms.Base
{
    public class MLTabPage : MetroFramework.Controls.MetroTabPage
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

        public MLTabPage()
        {
        }
    }
}
