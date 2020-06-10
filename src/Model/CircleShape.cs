using System;
using System.Drawing;

namespace Draw
{
	[Serializable]
	public class CircleShape : Shape
	{
		#region Constructor

		public CircleShape(RectangleF rect) : base(rect)
		{
		}

		public CircleShape(RectangleShape rectangle) : base(rectangle)
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

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawLine(new Pen(Color.Black), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width / 2, Rectangle.Y);
			grfx.DrawLine(new Pen(Color.Black), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X, Rectangle.Y + Rectangle.Height / 2);
			grfx.DrawLine(new Pen(Color.Black), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);


			grfx.DrawLine(new Pen(Color.Black), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 7, Rectangle.X, Rectangle.Y + Rectangle.Height / 7);
			grfx.DrawLine(new Pen(Color.Black), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 7, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 7);


			grfx.DrawLine(new Pen(Color.Black), Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height , Rectangle.X + Rectangle.Width / 2, Rectangle.Y);

			grfx.DrawEllipse(new Pen(BorderColor), x: Rectangle.X, y: Rectangle.Y, width: Rectangle.Width, height: Rectangle.Height);
		}
	}
}

