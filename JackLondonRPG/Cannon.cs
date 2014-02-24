using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Cannon : IAttacker, IDrawable
	{
		public Stat<int> Damage
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public Stat<int> Precision
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public AttackEvent Attack(IAttackable target)
		{
			throw new NotImplementedException();
		}

		public int GetDamage()
		{
			throw new NotImplementedException();
		}

		public char[,] GetImage()
		{
			throw new NotImplementedException();
		}

		public string Name
		{
			get { throw new NotImplementedException(); }
		}
	}
}
