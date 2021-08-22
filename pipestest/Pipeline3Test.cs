using System;
using Xunit;
using pipeslib.HandlersCoR;
using System.Collections.Generic;
using pipeslib;

namespace pipestest
{
    public class Pipeline3Test
    {
        [Fact]
        public void Run_WithHandlers_ReturnsDataOut()
        {
            //Arrange
            IEnumerable<IHandlerCoR<string>> steps = new IHandlerCoR<string>[] {
                new Handler1(),
                new Handler2()
            };
            IPipeline<string> pipe = new Pipeline3<string>(steps);

            //Act
            string dataIn = "pipestart";
            string dataOut = pipe.Run(dataIn);

            //Assert
            Assert.NotNull(dataOut);
        }
    }
}