using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {
        public Storm(string essence, bool isStrong, string caster, string location)
        {
            Location = location;
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
            if (isStrong)
            {
                Strength = "strong";
            }
            else if (!isStrong)
            {
                Strength = "weak";
            }
        }

        public override void Announce()
        {
            string announcement = $"{Caster}, from {Location}, cast a {Strength} {Essence} storm.";
            Console.WriteLine(announcement);
        }
    }
}
