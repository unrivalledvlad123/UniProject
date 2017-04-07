using System;
using Common;
using MetroFramework.Controls;

namespace Common.Forms.Base
{
	/// <summary>
	/// Multi-Language RadioButton implementation
	/// </summary>
	public class MLRadioButton : MetroRadioButton
	{
		public new string Text
		{
			get{ return base.Text; }
			set
			{
				if( DataHolder.DesignMode )
					base.Text = value;
				else
					base.Text = DataHolder.GetString( value );
			}
		}

		public MLRadioButton()
		{
		}
	}
}
