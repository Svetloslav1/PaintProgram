using System;
using System.Drawing;

namespace Draw
{
	[Serializable]
	public class Pismo : Shape
	{
		#region Constructor

		public Pismo(RectangleF rect) : base(rect)
		{
		}

		public Pismo(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion


		public override bool Contains(PointF point)
		{
			if (base.Contains(point))

				return true;
			else

				return false;
		}


		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawLine(new Pen(BorderColor), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y);
			grfx.DrawLine(new Pen(BorderColor), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X, Rectangle.Y);
			grfx.DrawRectangle(new Pen(BorderColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
	}
}
