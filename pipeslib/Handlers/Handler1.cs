using System;

namespace pipeslib.Handlers 
{
    public class Handler1 : IHandler<string>
    {
        public string Process(string dataIn)
        {
            string dataOut = $"{dataIn} => handler1";
            return dataOut;
        }
    }
}