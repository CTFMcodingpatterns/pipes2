using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeslib
{
    public class Pipeline6<DataType> : IPipeline<DataType>
    {
        private IEnumerable<IHandlerCoR<DataType>> Handlers { get; }

        public Pipeline6(
            IHandlerCoR<DataType> handler1, 
            IHandlerCoR<DataType> handler2,
            IHandlerCoR<DataType> handlerStop,
            IHandlerCoR<DataType> handler3)
        {
            this.Handlers = new IHandlerCoR<DataType>[] {
                handler1,
                handler2,
                handlerStop,
                handler3
            };
        }

        public DataType Run(DataType dataIn) 
        {
            //functional approach
            var seed = (data: dataIn, doContinue: true);
            var result = this.Handlers
                .Aggregate(seed, (prev, handler) => {
                    var handlerResult = (prev.doContinue)
                        ? handler.Process(prev.data)
                        : (prev.data, false);
                    return handlerResult;
                });
            return result.data;
        }

        public DataType Run2(DataType inData) 
        {
            //with mutable data object
            DataType data = inData;
            bool doContinue = true;
            foreach(var handler in this.Handlers) {
                if (doContinue) {
                    var result = handler.Process(data);
                    data = result.data;
                    doContinue = result.doContinue;
                }
                // break;
            }        
            return data;
        }

    }
}