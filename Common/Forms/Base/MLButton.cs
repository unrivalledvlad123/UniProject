using Common;
using MetroFramework.Controls;
using System;

namespace Common.Forms.Base
{
	/// <summary>
	/// Multi-Language Button implementation	
	/// </summary>
	public class MLButton : MetroButton
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

		public MLButton()
		{
		}


    }
}
