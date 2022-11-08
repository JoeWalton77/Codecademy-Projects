namespace RoverControlCenter
{
    class Probe
    {
        // class could be used to practice using a shared superclass instead of a shared interface, interface is used as it is more efficient
        public virtual string GetInfo()
        {
            return "";
        }

        public virtual string Explore()
        {
            return "";
        }

        public virtual string Collect()
        {
            return "";
        }
    }
}