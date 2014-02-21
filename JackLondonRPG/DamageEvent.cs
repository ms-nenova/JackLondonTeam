using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class DamageEvent : GameEvent
	{
		public IDamageable DamagedEntity
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
