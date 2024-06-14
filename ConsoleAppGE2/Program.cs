using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppGE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();

                Console.Write("名前を入力 ＞ ");
                string name = Console.ReadLine();

                Console.Write("攻撃力を入力 ＞ ");
                int atk = int.Parse(Console.ReadLine());

                Console.Write("防御力を入力 ＞ ");
                int def = int.Parse(Console.ReadLine());

                Console.Write("すばやさを入力 ＞ ");
                int spd = int.Parse(Console.ReadLine());

                players[i].CreatePlayer(name, atk, def, spd);
            }

            for(int i = 0; i < players.Length; i++)
            {
                players[i].ShowPlayer();
            }
        }
    }
}
