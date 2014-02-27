using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class BattleEngine
    {
        private static Ship enemyShip;
        private static Ship playerShip;

        public BattleEngine(Ship ship)
        {
            playerShip = ship;
            enemyShip = Opponent.GenerateShip(ship);
        }

        public static Ship PlayerShip
        {
            get
            {
                return playerShip;
            }
            set
            {
                playerShip = value;
                foreach (var skill in playerShip.Captain.Abilities)
                {
                    if (skill is PassiveSkill)
                    {
                        skill.Apply(playerShip);
                    }
                }
            }
        }

        public static Ship EnemyShip
        {
            get
            {
                return enemyShip;
            }
            set
            {
                enemyShip = value;
            }
        }
        public void MakeMove()
        {
            ListenForAction();
        }

        public static void ListenForAction()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.N)
                {
                    Shoot();
                }
                else if (pressedKey.Key == ConsoleKey.K)
                {
                    CastAbility(PlayerShip, 1);
                }
                else if (pressedKey.Key == ConsoleKey.M)
                {
                    CastAbility(PlayerShip, 2);
                }
            }
        }

        private static void CastAbility(Ship ship, int skillIndex)
        {
            if (PlayerShip.Captain.Abilities[skillIndex] is ActiveSkill)
            {
                var obj = new object();
                if (PlayerShip.Captain.Abilities[skillIndex] is Fireball)
                {
                    obj = EnemyShip.Walls[ChooseTarget()];
                }
                else if (PlayerShip.Captain.Abilities[skillIndex] is Fog)
                {
                    obj = EnemyShip.Cannons[ChooseTarget()];
                }
                else if (PlayerShip.Captain.Abilities[skillIndex] is HullBreaker)
                {
                    obj = EnemyShip.CurrHealth;
                }
                int target = ChooseTarget();
                PlayerShip.Captain.UseAbility(skillIndex, obj);
            }
            else
            {
                Console.WriteLine("This skill is passive and has already been cast.");
            }
        }

        private static void Shoot()
        {
            for (int i = 0; i < PlayerShip.Cannons.Count; i++)
            {
                if (EnemyShip.Walls[i].CurrHealth > 0)
                {
                    PlayerShip.Cannons[i].Attack(EnemyShip.Walls[i]);
                }
                else
                {
                    PlayerShip.Cannons[i].Attack(EnemyShip);
                }
            }
            for (int i = 0; i < EnemyShip.Cannons.Count; i++)
            {
                if (PlayerShip.Walls[i].CurrHealth > 0)
                {
                    EnemyShip.Cannons[i].Attack(PlayerShip.Walls[i]);
                }
                else
                {
                    PlayerShip.Cannons[i].Attack(PlayerShip);
                }
            }
        }

        public static int ChooseTarget()
        {
            Console.WriteLine("Choose a target for your spell (1-{0}).", EnemyShip.Cannons.Count);
            int target = int.Parse(Console.ReadLine());
            return target;
        }

    }


}

