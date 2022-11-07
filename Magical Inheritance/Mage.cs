using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {
            Title = title;
        }

        public Mage(string title, string origin) : base(title, origin)
        {
            Title = title;
            Origin = origin;
        }

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title, Origin); 
        }
    }
}