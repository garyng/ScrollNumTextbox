using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
	class ScrollNumText : TextBox
	{
		enum Direction
		{
			Vertical,
			Horizontal,
			None
		}

		public ScrollNumText()
		{

			Direction curDir = new Direction();
			Point pDown = new Point(-1, -1);
			Point? pPre = null;
			this.ShortcutsEnabled = false;
			this.MouseDown += delegate(object s, MouseEventArgs ev)
			{
				pDown = ev.Location;
			};

			this.MouseUp += delegate(object s, MouseEventArgs ev)
			{
				pDown = new Point(-1, -1);
				curDir = Direction.None;
			};

			this.MouseMove += delegate(object s, MouseEventArgs ev)
			{
				Console.WriteLine(curDir.ToString());
				if (pDown.X >= 0 || pDown.Y >= 0)
				{
					long num;
					long.TryParse(this.Text, out num);
					bool isBackward = false;
					//TODO: set 10 
					if (Math.Abs((ev.Location.X - pDown.X)) > 10 && (ev.Location.X - pDown.X) % 5 == 0)
					{
						if (curDir == Direction.None)
						{
							curDir = Direction.Vertical;
						}
						if (curDir == Direction.Vertical)
						{
							if (pPre.HasValue && (ev.Location.X - pPre.Value.X) < 0)
							{
								isBackward = true;
							}
							if ((ev.Location.X - pDown.X) > 0 && !isBackward)
							{
								num += 1;
							}
							else if ((ev.Location.X - pDown.X) < 0 || isBackward)
							{
								num -= 1;
							}
						}
					}
					else if (Math.Abs((ev.Location.Y - pDown.Y)) > 10 && (ev.Location.Y - pDown.Y) % 5 == 0)
					{
						if (curDir == Direction.None)
						{
							curDir = Direction.Horizontal;
						}
						if (curDir == Direction.Horizontal)
						{
							if (pPre.HasValue && (ev.Location.Y - pPre.Value.Y) > 0)
							{
								isBackward = true;
							}
							if ((ev.Location.Y - pDown.Y) < 0 && !isBackward)
							{
								num += 1;
							}
							else if ((ev.Location.Y - pDown.Y) > 0 || isBackward)
							{
								num -= 1;
							}
						}
					}
					pPre = ev.Location;
					this.Text = num.ToString();
				}
			};

			this.KeyDown += delegate(object s, KeyEventArgs ev)
			{
				Console.WriteLine((char)ev.KeyCode);
				if (!(ev.KeyCode == Keys.Back || char.IsDigit((char)ev.KeyCode)))
				{
					ev.SuppressKeyPress = true;
				}
			};
		}

		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				long num;
				if (long.TryParse(base.Text, out num))
				{
					base.Text = value;
				}
				else
				{
					base.Text = "0";
				}

			}
		}
	}

}
