using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Player
    {
        public string name { get; set; }
        public int atk { get; set; }
        public int def {  get; set; }
        public int spd { get; set; }

        public void CreatePlayer(string name,int atk,int def,int spd)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.spd = spd;
        } 

        public void ShowPlayer()
        {
            Console.WriteLine("プレイヤー名：" + name + "攻撃力：" + atk + "防御力：" + def + "すばやさ" + spd);
            Console.ReadLine();
        }
    }
}
