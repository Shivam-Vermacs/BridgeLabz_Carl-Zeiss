using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Review
{
    internal class RPGEvolution
    {
        class Warrior
        {
            public virtual double attack()
            {
                return 100;
            }
        }
        class Paladin : Warrior
        {
            public override double attack()
            {
                double p= base.attack();
                return (p * 1.2);
            }
            public void heal()
            {
                Console.WriteLine("Heal Done");
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                Warrior a = new Warrior();
                Console.WriteLine(a.attack());
                Warrior b = new Paladin();
                Console.WriteLine(b.attack());
                Paladin p = new Paladin();
                p.heal();
            }
        }
        
    }
}
