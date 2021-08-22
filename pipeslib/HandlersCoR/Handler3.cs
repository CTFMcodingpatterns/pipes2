using System;

namespace pipeslib.HandlersCoR
{
    public class Handler3 : IHandlerCoR<string>
    {
        public (string, bool) Process(string dataIn)
        {
            string dataOut = $"{dataIn} => handler3";
            bool doContinue = true;
            return (dataOut, doContinue);
        }
    }
}