using System;

namespace MagicalInheritance
{
    class Pupil
    {
        public string Title
            { get; protected set; }
        public string Origin
            { get; protected set; }

        public Pupil(string title)
        {
            Title = title;
        }

        public Pupil(string title, string origin)
        {
            Title = title;
            Origin = origin;
        }

        public Storm CastWindStorm()
        {
           return new Storm("wind", false, Title, Origin);
        }
    }
}
