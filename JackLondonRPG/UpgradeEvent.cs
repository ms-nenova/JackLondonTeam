using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
	public class UpgradeEvent : GameEvent
	{
		public UpgradeEvent(IUpgradable<object> upgradedEntity)
		{
			this.UgradedEntity = upgradedEntity;
		}

		public IUpgradable<object> UgradedEntity { get; private set; }

		public override string GetMessage()
		{
			string returnValue = "";

			returnValue += this.UgradedEntity.Name + " gets upgraded to rank " + this.UgradedEntity.CurrRank;

			return returnValue;
		}
	}
}
