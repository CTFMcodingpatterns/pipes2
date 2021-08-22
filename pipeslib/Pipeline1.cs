using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeslib
{
    public class Pipeline1<DataType> : IPipeline<DataType>
    {
        IEnumerable<IHandler<DataType>> Steps { get; }
        
        public Pipeline1(IEnumerable<IHandler<DataType>> steps)
        {
           this.Steps = steps; 
        }

        public DataType Run(DataType inData) 
        {
            //TODO: no inplace data!
            DataType data = inData;
            foreach(var step in this.Steps) {
                data = step.Process(data);
            }        
            return data;
        }
    }
}