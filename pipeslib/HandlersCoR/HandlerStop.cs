using System;

namespace pipeslib.HandlersCoR
{
    public class HandlerStop : IHandlerCoR<string>
    {
        public (string, bool) Process(string dataIn)
        {
            string dataOut = $"{dataIn} => STOP!";
            bool doContinue = false;
            return (dataOut, doContinue);
        }
    }
}