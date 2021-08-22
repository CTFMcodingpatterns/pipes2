using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeslib
{
    public class Pipeline4<DataType> : IPipeline<DataType>
    {
        private IHandler<DataType> Handler1 {get;}
        private IHandler<DataType> Handler2 {get;}
        private IHandler<DataType> Handler3 {get;}

        public Pipeline4(IHandler<DataType> handler1, IHandler<DataType> handler2, IHandler<DataType> handler3)
        {
            this.Handler1 = handler1;
            this.Handler2 = handler2;
            this.Handler3 = handler3;
        }

        public DataType Run(DataType inData) 
        {
            var result1 = this.Handler1.Process(inData);
            var result2 = this.Handler2.Process(result1);
            var outData = this.Handler3.Process(result2);
            return outData;
        }
    }
}