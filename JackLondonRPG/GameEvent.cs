using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public abstract class GameEvent : IDrawable
	{
		public abstract string GetMessage();

		public char[,] GetImage()
		{
			// return this.GetMessage();
			throw new System.NotImplementedException();
		}
	}
}
