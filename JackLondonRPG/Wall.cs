﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Wall : IAttackable, IDamageable, IDrawable
	{
        private string name;
        private int currHealth;

		public AttackEvent GetAttacked(IAttacker attacker)
		{
			// attacker.GetDamage();
			throw new System.NotImplementedException();
		}

		public void GetDamaged(int damage)
		{
            this.currHealth -= damage;
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
