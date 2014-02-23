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
			get;set; 
		}

		public T CurrValue
		{
			get;set;
		}

        public int MaxRank
        {
            get;
            set;
        }

        //public List<int> UpdgradeCosts
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        public int RankValues
        {
            get;
            set;
        }

		public void RankUp(int rankManipulator)//rankManipulator shows by how many ranks the stat should go up or down in case of negative numbers.
		{
			throw new NotImplementedException();
		}

		public void RankUp(ref int goldProvider)
		{
			throw new NotImplementedException();
		}
	}
}
