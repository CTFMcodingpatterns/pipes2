using System;

namespace pipeslib.Handlers 
{
    public class Handler2 : IHandler<string>
    {
        public string Process(string dataIn)
        {
            string dataOut = $"{dataIn} => handler2";
            return dataOut;
        }
    }
}