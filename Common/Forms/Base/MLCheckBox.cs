using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using MetroFramework.Controls;

namespace Common.Forms.Base
{
	public partial class MLCheckBox : MetroCheckBox
	{

		public new string Text
		{
			get { return base.Text; }
			set
			{
				if ( DataHolder.DesignMode )
					base.Text = value;
				else
					base.Text = DataHolder.GetString( value );
			}
		}
	}
}
