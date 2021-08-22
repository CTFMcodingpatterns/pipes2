using System;
using Xunit;
using pipeslib.Handlers;
using System.Collections.Generic;
using pipeslib;

namespace pipestest
{
    public class Pipeline2Test
    {
        [Fact]
        public void Run_WithHandlers_ReturnsDataOut()
        {
            //Arrange
            IEnumerable<IHandler<string>> steps = new IHandler<string>[] {
                new Handler1(),
                new Handler2(),
                new Handler3()
            };
            IPipeline<string> pipe = new Pipeline2<string>(steps);

            //Act
            string dataIn = "pipestart";
            string dataOut = pipe.Run(dataIn);

            //Assert
            Assert.NotNull(dataOut);
        }
    }
}