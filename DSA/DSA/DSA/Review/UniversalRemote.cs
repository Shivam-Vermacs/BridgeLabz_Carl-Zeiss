using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Review
{
    internal class UniversalRemote
    {
       abstract class Device
        {
            public abstract void turn_on();
        }
        class Light : Device
        {
            public override void turn_on()
            {
                Console.WriteLine("Light is Turned On");
            }
        }
        class AC : Device
        {
            public override void turn_on()
            {
                Console.WriteLine("AC is Turned On");
            }
        }
        class TV : Device
        {
            public override void turn_on()
            {
                Console.WriteLine("TV is Turned On");
            }
        }
        class RemoteControl
        {
            public void press(Device[] d)
            {
               for(int i = 0; i < d.Length; i++)
                {
                    d[i].turn_on();
                }
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                Device[] d = new Device[3];
                d[0] = new Light();
                d[1] = new AC();
                d[2] = new TV();

                RemoteControl r = new RemoteControl();
                r.press(d);
            }
        }
    }
}
