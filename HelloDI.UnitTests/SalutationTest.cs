using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloDI.UnitTests
{
    [TestClass]
    public class SalutationTest
    {
        [TestMethod]
        public void ExclaimWillWriteCorrectMessageToMessageWriter()
        {
            var writeMock = new Mock<IMessageWriter>();
            var sut = new Salutation(writeMock.Object);

            sut.Exclaim();

            writeMock.Verify(w => w.Write("Hello DI!"));
        }
    }
}
