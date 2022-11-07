using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {
            Title = title;
        }

        public Archmage(string title, string origin) : base(title, origin)
        {
            Title = title;
            Origin = origin;
        }

        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title, Origin);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title, Origin);
        }
    }
}