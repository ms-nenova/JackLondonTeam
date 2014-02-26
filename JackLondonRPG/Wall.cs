using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Wall : IAttackable, IDamageable, IDrawable
	{
        private string name;
        private int currHealth;
        public Stat<int> MaxHealth { get; private set; }
       
        public Wall(string name, int currHealth, Stat<int> maxHealth)
        {
            this.Name = name;
            this.CurrHealth = currHealth;
            this.MaxHealth = maxHealth;
        }

		public AttackEvent GetAttacked(IAttacker attacker)
		{
			// attacker.GetDamage();
			throw new System.NotImplementedException();
		}

		public DamageEvent GetDamaged(int damage)
		{
            int finalHealth = currHealth - damage;

            if (finalHealth>MaxHealth.CurrValue)
            {
                finalHealth = MaxHealth.CurrValue;
            }

            if (finalHealth<0)
            {
                finalHealth = 0;
            }

            currHealth = finalHealth;

            return new DamageEvent(this, damage);
		}

		public int CurrHealth
		{
			get
			{
                return this.currHealth;
			}

			set
			{
                if (value < 0)
                {
                    throw new ArgumentException("Current health cannot be negative!");
                }
                this.currHealth = value;
			}
		}

		public char[,] GetImage()
		{
            char[,] wall = new char[6, 3] { 
                                            { '|', ' ', '|' },
                                            { '|', ' ', '|' },
                                            { '|', ' ', '|' },
                                            { '|', ' ', '|' },
                                            { '|', ' ', '|' },
                                            { '|', ' ', '|' },                                                     
                                           };
            return wall;
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

	}
}
