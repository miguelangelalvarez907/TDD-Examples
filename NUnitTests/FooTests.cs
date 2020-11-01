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
        private Mock<IFoo> _fooMock;
        public FooTests()
        {

        }

        [SetUp]
        public void Setup()
        {
            _fooMock = new Mock<IFoo>();
        }

        [Test]
        public void Test_Some_Oridary_MethodCall()
        {
            _fooMock.Setup(foo => foo.DoSomething("ping")).Returns(true);
            _fooMock.Setup(foo => foo.DoSomething(It.IsIn("pong", "foo"))).Returns(false);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(_fooMock.Object.DoSomething("ping"));
                Assert.IsFalse(_fooMock.Object.DoSomething("pong"));
                Assert.IsFalse(_fooMock.Object.DoSomething("foo"));
            });
        }

        [Test]
        public void Test_Arguement_Matching()
        {
            _fooMock.Setup(foo => foo.DoSomething(It.IsAny<string>())).Returns(true);

            _fooMock.Setup(foo => foo.Add(It.Is<int>(x => x % 2 == 0))).Returns(true);

            //_fooMock.Setup(foo => foo.Add(It.IsInRange<int>(1, 10, Moq.Range.Inclusive))).Returns(false);

            //_fooMock.Setup(foo => foo.DoSomething(It.IsRegex("[a-z]+"))).Returns(false);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(_fooMock.Object.DoSomething("ping"));
                Assert.IsTrue(_fooMock.Object.Add(2));
            });
        }

        [Test]
        public void Test_Out_Argurments()
        {
            var requiredOut = "ok";

            _fooMock.Setup(foo => foo.TryParse("ping", out requiredOut)).Returns(true);

            string result;
            Assert.Multiple(() =>
            {
                Assert.IsTrue(_fooMock.Object.TryParse("ping", out result));
                Assert.That(result, Is.EqualTo(requiredOut));
            });
        }

        [Test]
        public void Test_Ref_Argurments()
        {
            var bar = new Bar();
            var barTwo = new Bar();

            _fooMock.Setup(foo => foo.Submit(ref bar)).Returns(true);

            Assert.Multiple(() =>
            {
                Assert.That(_fooMock.Object.Submit(ref bar), Is.EqualTo(true));
                Assert.IsFalse(_fooMock.Object.Submit(ref barTwo));
            });
        }
    }
}
