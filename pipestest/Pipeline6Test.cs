using System;
using Xunit;
using pipeslib.HandlersCoR;
using System.Collections.Generic;
using pipeslib;

namespace pipestest
{
    public class Pipeline6Test
    {
        [Fact]
        public void Run_WithHandlers_ReturnsDataOut()
        {
            //Arrange
            IHandlerCoR<string> handler1 = new Handler1();
            IHandlerCoR<string> handler2 = new Handler2();
            IHandlerCoR<string> handlerStop = new HandlerStop();
            IHandlerCoR<string> handler3 = new Handler3();
            IPipeline<string> pipe = new Pipeline6<string>(handler1, handler2, handlerStop, handler3);

            //Act
            string dataIn = "pipestart";
            string dataOut = pipe.Run(dataIn);

            //Assert
            Assert.NotNull(dataOut);
        }
    }
}