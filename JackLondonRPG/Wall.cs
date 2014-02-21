using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Wall : IAttackable, IDamageable, IDrawable
	{
		public void GetAttacked(IAttacker attacker)
		{
			throw new NotImplementedException();
		}

		public void GetDamaged(int damage)
		{
			throw new NotImplementedException();
		}

		public int CurrHealth
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public char[,] GetImage()
		{
			throw new NotImplementedException();
		}

		public string Name
		{
			get { throw new NotImplementedException(); }
			private set { throw new NotImplementedException(); }
		}

	}
}
