using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Stat<T> : IUpgradable<T>
	{
	
		public int CurrRank
		{
			get { throw new NotImplementedException(); }
		}

		public T CurrValue
		{
			get { throw new NotImplementedException(); }
		}

		public int MaxRank
		{
			get { throw new NotImplementedException(); }
		}

		public List<int> UpdgradeCosts
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public int RankValues
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public void RankUp()
		{
			throw new NotImplementedException();
		}

		public void RankUp(ref int goldProvider)
		{
			throw new NotImplementedException();
		}
	}
}
