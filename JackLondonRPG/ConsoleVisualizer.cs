using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
	public static class ConsoleVisualizer
	{
		public const int cannonBuffer = 4;
		public const int wallBuffer = 4;
		public const int shipHealthBuffer = 4;
		public const int distanceBetweenShips = 10;

		public static void VisualizeDrawable(IDrawable drawable)
		{
			var img = drawable.GetImage();
			int rows = img.GetLength(0);
			int cols = img.GetLength(1);

			for (int i = 0; i < rows; ++i)
			{
				for (int j = 0; j < cols; ++j)
				{
					Console.Write(img[i, j]);
				}
				Console.WriteLine();
			}
		}

		public static void VisualizeMerchant(Merchant merchant)
		{

		}

		public static void VisualizeRepairman(Repairman repairman)
		{

		}

		public static void VisualizeBattleState(Ship firstShip, Ship secondShip, IEnumerable<GameEvent> events)
		{
			int numberOfShipsRows = firstShip.Cannons.Count;
			int middleRow = numberOfShipsRows / 2;

			for (int i = 0; i < numberOfShipsRows; ++i)
			{
				if (i == numberOfShipsRows)
				{
					Console.Write(firstShip.CurrHealth.ToString().PadRight(shipHealthBuffer, '*'));
				}

				else
				{
					Console.Write(new string('*', shipHealthBuffer));
				}

			}

			foreach (var gameEvent in events)
			{
				VisualizeDrawable(gameEvent);
				Console.WriteLine();
			}
		}


	}
}
