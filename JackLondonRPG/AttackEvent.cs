using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class AttackEvent : GameEvent
	{
		public AttackEvent(IAttacker attacker, IAttackable target)
		{
			this.attacker = attacker;
			this.target = target;
		}

		private IAttacker attacker;
		public IAttacker Attacker
		{
			get
			{
				return this.attacker;
			}
			private set
			{
				this.attacker = value;
			}
		}

		private IAttackable target;
		public IAttackable Target
		{
			get
			{
				return this.target;
			}
			private set
			{
				this.target = value;
			}
		}

		public override string GetMessage()
		{
			throw new NotImplementedException();
		}
	}
}
