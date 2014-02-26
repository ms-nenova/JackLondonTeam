using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Cannon : IAttacker, IDrawable
	{
		public Cannon(string name, Stat<int> damage, Stat<int> precision)
		{
			this.name = name;
			this.damage = damage;
			this.precision = precision;
		}

		private Stat<int> damage;
		public Stat<int> Damage
		{
			get
			{
				return this.damage;
			}
			private set
			{
				this.damage = value;
			}
		}

		private Stat<int> precision;
		public Stat<int> Precision
		{
			get
			{
				return this.precision;
			}
			private set
			{
				this.precision = value;
			}
		}

		public IEnumerable<GameEvent> Attack(IAttackable target)
		{
            int randomFactor = RandomGenerator.Random.Next();
            bool atkLanded;
            if (randomFactor%this.Precision.CurrValue>20)
            {
                atkLanded = true;
            }
            else
            {
                atkLanded = false;
            }
            List<GameEvent> events = new List<GameEvent>();
            
            events.Add(new AttackEvent(this, target, atkLanded));
            events.Add(new DamageEvent(target, 10));

            return events;
		}

		public int GetDamage()
		{
			throw new NotImplementedException();
		}

		public char[,] GetImage()
		{
			return new char[6, 3] { 
                                            { '>', ' ', '>' },
                                            { '>', ' ', '>' },
                                            { '>', ' ', '>' },
                                            { '>', ' ', '>' },
                                            { '>', ' ', '>' },
                                            { '>', ' ', '>' },
                                    };
		}

		private string name;
		public string Name
		{
			get { return this.name; }
			private set { this.name = value; }
		}
	}
}
