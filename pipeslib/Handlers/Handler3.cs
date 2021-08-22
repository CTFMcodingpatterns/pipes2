using System;

namespace pipeslib.Handlers 
{
    public class Handler3 : IHandler<string>
    {
        public string Process(string dataIn)
        {
            string dataOut = $"{dataIn} => handler3";
            return dataOut;
        }
    }
}