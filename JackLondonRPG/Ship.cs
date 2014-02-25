using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Ship : IAttackable, IDamageable, IAttacker, IDrawable
	{
        private string name;
        private Captain captain;
        private int currHealth;
        private IList<Wall> wall;
        private IList<Cannon> cannon;
        private Stat<int> mobility;

        public Ship(string name, Captain captain, int currHealth, List<Wall> wall, List<Cannon> cannon, Stat<int> mobility)
        {
            this.Name = name;
            this.Captain = captain;
            this.CurrHealth = currHealth;
            this.Walls = new List<Wall>(wall);
            this.Cannons = new List<Cannon>(cannon);
            this.Mobility = mobility;
        }

        public Stat<int> Mobility
        {
            get;
            private set;
        }

		public List<Cannon> Cannons
		{
			get
			{
                return new List<Cannon>();
			}

			private set
			{
                this.cannon = value;
			}
		}

		public List<Wall> Walls
		{
			get
			{
				return new List<Wall>();
			}

			private set
			{
                this.wall = value;
			}
		}

		public AttackEvent GetAttacked(IAttacker attacker)
		{
            // attacker.GetDamage();
			throw new NotImplementedException();
		}

        public int CurrHealth
        {
            get
            {
                return this.currHealth;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Current health cannot be negative!");
                }
                this.currHealth = value;
            }
        }

		public void GetDamaged(int damage)
		{
            this.currHealth -= damage;
		}

		public Captain Captain
		{
			get
			{
                return this.captain;
			}

            private set
            {
                this.captain = value;
            }
		}

		public string Name
		{
            get { return this.name; }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
                this.name = value;
            }
		}

		public AttackEvent Attack(IAttackable target)
		{
			throw new NotImplementedException();
		}

        public void GetDamaged(int damage)
        {
            this.currHealth -= damage;
        }

		public char[,] GetImage()
		{
			throw new NotImplementedException();
		}
	}
}
