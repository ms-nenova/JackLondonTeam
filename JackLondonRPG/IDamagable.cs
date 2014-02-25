﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public interface IDamageable : IIdentifiable
	{
		int CurrHealth
		{
			get;
			set;
		}
	
		DamageEvent GetDamaged(int damage);
	}
}
