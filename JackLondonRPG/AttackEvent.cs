using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class AttackEvent : GameEvent
	{
		public IAttacker Attacker
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public IAttackable Target
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public override string GetMessage()
		{
			throw new NotImplementedException();
		}
	}
}
