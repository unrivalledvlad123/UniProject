using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Forms.Base
{
	public class MLForm : MetroForm
	{

		public MLForm()
		{
		
		}

		public void InitializeThemeAndStyle(MetroStyleManager metroStyleManager, bool isAdminForm)
		{
			if (isAdminForm)
			{
				//metroStyleManager.Theme = DataHolder.AdminFormTheme;
				//Theme = DataHolder.AdminFormTheme;

				//metroStyleManager.Style = DataHolder.AdminFormStyle;
				//Style = DataHolder.AdminFormStyle;
			}
			else
			{
				//metroStyleManager.Theme = DataHolder.MainFormTheme;
				//Theme = DataHolder.MainFormTheme;

				//metroStyleManager.Style = DataHolder.MainFormStyle;
				//Style = DataHolder.MainFormStyle;
			}			
		}

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }
    }
}
