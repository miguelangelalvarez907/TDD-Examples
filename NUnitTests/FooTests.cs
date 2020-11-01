using Moq;
using NUnit.Framework;
using NUnitTests.Foo;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class FooTests
    {
        [Test]
        public void TestSomeOridaryMethodCall()
        {
            var mock = new Mock<IFoo>();

            mock.Setup(foo => foo.DoSomething("ping")).Returns(true);
            mock.Setup(foo => foo.DoSomething(It.IsIn("pong", "foo"))).Returns(false);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(mock.Object.DoSomething("ping"));
                Assert.IsFalse(mock.Object.DoSomething("pong"));
                Assert.IsFalse(mock.Object.DoSomething("foo"));
            });
        }
    }
}
