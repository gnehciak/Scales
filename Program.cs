using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scales
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            string[] MajorKeys = { "B", "F#", "Eb", "Ab" };
            string[] MinorKeys = { "Ab", "Eb", "C", "F" };
            string[] DynamicLevel = { "ppp", "pp", "p", "mp", "mf", "f", "ff", "fff" };
            string[] Dynamics = { "Cres then Dim", "Dim then Cres", ""};
            string[] Minors = { "Natural", "Harmonic" };
            string[] Articulation = { "Legato", "Staccato" };
            string[] Inversions = { "Root", "First Inversion", "Second Inversion" };

            var random = new Random();
            //Scale
            if (random.Next(2) == 0)
            {
                int r = random.Next(2);
                int KeyI = random.Next(MajorKeys.Length);
                int DynamicLevelI = random.Next(DynamicLevel.Length);
                int DynamicsI = random.Next(Dynamics.Length);
                int MinorsI = random.Next(Minors.Length);
                int ArticulationI = random.Next(Articulation.Length);
                switch (r)
                {
                    //Normal Scale
                    case 0:
                        //Major
                        if (random.Next(2) == 0)
                        {
                            Console.WriteLine(MajorKeys[KeyI] + " Major");
                            Console.WriteLine(DynamicLevel[DynamicLevelI]);
                            Console.WriteLine(Dynamics[DynamicsI]);
                            Console.WriteLine(Articulation[ArticulationI]);
                        }
                        //Minor
                        else
                        {
                            Console.WriteLine($"{MinorKeys[KeyI]} {Minors[MinorsI]} Minor");
                            Console.WriteLine(DynamicLevel[DynamicLevelI]);
                            Console.WriteLine(Dynamics[DynamicsI]);
                            Console.WriteLine(Articulation[ArticulationI]);
                        }
                        break;
                    //Contramotion
                    case 1:
                        //Major
                        if (random.Next(2) == 0)
                        {
                            Console.WriteLine(MajorKeys[KeyI] + " Major Contramotion");
                        }
                        //Minor
                        else
                        {
                            Console.WriteLine(MinorKeys[KeyI] + " Minor Contramotion");
                        }
                        break;
                }
            }
            //Arpeggio
            else
            {
                int KeyI = random.Next(MajorKeys.Length);
                int InversionsI = random.Next(Inversions.Length);
                int rnd = random.Next(4);
                //Major
                if (rnd == 0)
                {
                    Console.WriteLine(MajorKeys[KeyI] + " Major");
                    Console.WriteLine(Inversions[InversionsI]);
                }
                //Minor
                else if (rnd == 1)
                {
                    Console.WriteLine(MajorKeys[KeyI] + " Minor");
                    Console.WriteLine(Inversions[InversionsI]);
                }
                //Diminished
                else if (rnd == 2)
                {
                    Console.WriteLine(MajorKeys[KeyI] + " Major Diminished Appegio");
                }
                //Dominant 7th
                else
                {
                    Console.WriteLine(MajorKeys[KeyI] + " Major Dominant 7th Appegio");
                }
            }
            Console.ReadLine();
            Console.Clear();
            goto start;
        }
    }
}
