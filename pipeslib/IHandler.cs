using System;

namespace pipeslib
{
    public interface IHandler<DataType>
    {
        DataType Process(DataType data);
        // void Process(DataType data);
    }
}