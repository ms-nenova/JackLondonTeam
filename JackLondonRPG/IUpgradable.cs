using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public interface IUpgradable<T>
	{
		int CurrRank
		{
			get;
			private set;
		}

		T CurrValue
		{
			get;
		}

		int MaxRank
		{
			get;
			private set;
		}
	
		void RankUp();
	}
}
