using System;
using Common;
using MetroFramework.Controls;

namespace Common.Forms.Base
{
	/// <summary>
	/// Multi-Language Label implementation
	/// </summary>
	public class MLLabel : MetroLabel
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

		public MLLabel()
		{
			FontWeight = MetroFramework.MetroLabelWeight.Regular;
		}
	}
}
