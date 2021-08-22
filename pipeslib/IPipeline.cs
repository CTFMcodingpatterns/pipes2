using System;

namespace pipeslib
{
    public interface IPipeline<DataType>
    {
        DataType Run(DataType data);
    }
}