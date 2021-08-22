using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeslib
{
    public class Pipeline3<DataType> : IPipeline<DataType>
    {
        IEnumerable<IHandlerCoR<DataType>> Steps { get; }
        
        public Pipeline3(IEnumerable<IHandlerCoR<DataType>> steps)
        {
           this.Steps = steps; 
        }

        public DataType Run(DataType dataIn) {
            (DataType data, bool doContinue) seed = (dataIn, true);
            (DataType data, bool doContinue) result = Steps
                .Aggregate(seed, (prev, handler) => {
                    var handlerResult = (prev.doContinue)
                        ? handler.Process(prev.data)
                        : (prev.data, false);
                    return handlerResult;
                });
            return result.data;
        }

        [Obsolete("mutable data")]
        public DataType Run2(DataType inData) 
        {
            //TODO: no inplace data!
            DataType data = inData;
            bool doContinue = true;
            foreach(var step in this.Steps) {
                if (doContinue) {
                    var result = step.Process(data);
                    data = result.data;
                    doContinue = result.doContinue;
                }
                // break;
            }        
            return data;
        }
    }
}