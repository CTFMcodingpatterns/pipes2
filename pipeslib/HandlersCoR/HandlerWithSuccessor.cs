using System;

namespace pipeslib.HandlersCoR
{
    public class HandlerWithSuccessor
    {
        private HandlerWithSuccessor Successor {get;}

        public void Process1(string dataIn) {
            string dataOut = $"{dataIn} => handler1";
            this.Successor.Process1(dataOut);
        }

        public void Process2(object data) {
            data = default;  //with in place modification of data
            this.Successor.Process2(data);
        }
    }
}