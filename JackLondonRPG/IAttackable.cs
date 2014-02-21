﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public interface IAttackable : IIdentifiable
	{
		AttackEvent GetAttacked(IAttacker attacker);
	}
}
