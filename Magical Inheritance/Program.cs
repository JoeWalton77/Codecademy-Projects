using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];

            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            Mage m = new Mage("Gul'dan", "Draenor");
            Archmage a = new Archmage("Nielas Aran", "Stormwind");

            storms[0] = p.CastWindStorm();
            storms[1] = m.CastWindStorm();
            storms[2] = m.CastRainStorm();
            storms[3] = a.CastWindStorm();
            storms[4] = a.CastRainStorm();
            storms[5] = a.CastLightningStorm();

            for (int i = 0; i < storms.Length; i++)
            {
                if (storms[i] != null)
                {
                    storms[i].Announce();
                }
            }
        }
    }
}