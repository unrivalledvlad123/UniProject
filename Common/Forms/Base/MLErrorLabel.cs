using System;
using System.Drawing;
using Common;
using MetroFramework.Controls;

namespace Common.Forms.Base
{
	/// <summary>
	/// Multi-Language Label implementation
	/// </summary>
	public sealed class MLErrorLabel : System.Windows.Forms.Label
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

		public MLErrorLabel()
		{
			ForeColor = Color.Red;
		}
	}
}
