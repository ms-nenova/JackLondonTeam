using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Ship : IAttackable, IDamageable, IAttacker, IDrawable
	{
        public Stat<int> Mobility
        {
            get;
            set;
        }
		public List<Cannon> Cannons
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public List<Wall> Walls
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public void GetAttacked(IAttacker attacker)
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

		public void GetDamaged(int damage)
		{
			throw new NotImplementedException();
		}

		public Captain Captain
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public string Name
		{
			get { throw new NotImplementedException(); }
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
	}
}
