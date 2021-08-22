using System;

namespace pipeslib.HandlersCoR
{
    public class Handler1 : IHandlerCoR<string>
    {
        (string, bool) IHandlerCoR<string>.Process(string dataIn)
        {
            string dataOut = $"{dataIn} => handler1";
            bool doContinue = true;
            return (dataOut, doContinue);
        }
    }
}