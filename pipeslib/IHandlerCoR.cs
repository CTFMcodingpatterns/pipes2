using System;

namespace pipeslib
{
    // CoR = Chain of Responsibility
    // this means the Handler decides wether another Handler should be called or not
    public interface IHandlerCoR<DataType>
    {
        (DataType data, bool doContinue) Process(DataType data);
    }
}