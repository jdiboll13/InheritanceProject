using System;

namespace InheritanceProject
{
    public class NoTransportException : Exception
    {
        public NoTransportException() : base("Custom Exception Message for this Error.")
        { }
    }
}