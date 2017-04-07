using MetroFramework.Controls;

namespace Common.Forms.Base
{
	public class MLLink : MetroLink
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

		public MLLink()
		{
			
		}
	}
}
