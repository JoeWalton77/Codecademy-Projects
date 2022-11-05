using System;

namespace AppInterfaces
{
    interface IDisplayable
    {
        char HeaderSymbol { get; }
        void Display();     
    }
}