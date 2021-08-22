using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeslib
{
    public class Pipeline5<DataType> : IPipeline<DataType>
    {
        private IHandlerCoR<DataType> Handler1 {get;}
        private IHandlerCoR<DataType> Handler2 {get;}
        private IHandlerCoR<DataType> Handler3 {get;}

        public Pipeline5(IHandlerCoR<DataType> handler1, IHandlerCoR<DataType> handler2, IHandlerCoR<DataType> handler3)
        {
            this.Handler1 = handler1;
            this.Handler2 = handler2;
            this.Handler3 = handler3;
        }

        public DataType Run(DataType inData) 
        {
            var result1 = (true)               ? this.Handler1.Process(inData)       : (data: inData, doContinue: false);
            var result2 = (result1.doContinue) ? this.Handler2.Process(result1.data) : (data: result1.data, doContinue: false);
            var result3 = (result2.doContinue) ? this.Handler2.Process(result2.data) : (data: result2.data, doContinue: false);
            var dataOut = result3.data;
            return dataOut;
        }

    }
}