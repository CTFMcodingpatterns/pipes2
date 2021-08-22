using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeslib
{
    public class Pipeline2<DataType> : IPipeline<DataType>
    {
        IEnumerable<IHandler<DataType>> Steps { get; }
        
        public Pipeline2(IEnumerable<IHandler<DataType>> steps)
        {
           this.Steps = steps; 
        }

        public DataType Run(DataType dataIn) {
            DataType dataOut = Steps
                .Aggregate(dataIn, (acc, step) => step.Process(acc));
            return dataOut;
        }

    }
}