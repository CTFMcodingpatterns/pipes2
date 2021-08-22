using System;

namespace pipeslib.HandlersCoR
{
    public class Handler2 : IHandlerCoR<string>
    {
        (string, bool) IHandlerCoR<string>.Process(string dataIn)
        {
            string dataOut = $"{dataIn} => handler2";
            bool doContinue = true;
            return (dataOut, doContinue);
        }
    }
}