using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
            { get; private set; }
        public bool IsStrong
            { get; private set; }
        public string Strength
            { get; private set; }
        public string Caster
            { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            essence = Essence;
            isStrong = IsStrong;
            caster = Caster;
            if (isStrong)
            {
                Strength = "strong";
            }
            else if (!isStrong)
            {
                Strength = "weak";
            }
        }

        public string Announce()
        {
            if (IsStrong)
            {

            }
            string announcement = $"{Caster} cast a {Strength} {Essence} storm.";
            return announcement;
        }
    }
}
