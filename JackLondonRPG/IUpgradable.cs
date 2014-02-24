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
		}

		T CurrValue
		{
			get;
		}

		int MaxRank
		{
			get;
		}
	
		void RankChange(int rankManipulator);
		void RankChange(ref int goldProvider);
	}
}
