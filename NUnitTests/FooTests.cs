using Moq;
using NUnit.Framework;
using NUnitTests.Foo;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

        [Test]
        public void Test_String_Argurments()
        {
            _fooMock.Setup(foo => foo.ProcessString(It.IsAny<string>())).Returns((string s) => s.ToLowerInvariant());

            Assert.That(_fooMock.Object.ProcessString("ABC"), Is.EqualTo("abc"));
        }

        [Test]
        public void Test_CallBack_Argurments()
        {
            var countCall = 0;

            _fooMock.Setup(foo => foo.GetCount()).Returns(() => countCall).Callback(() => ++countCall); ;

            _fooMock.Object.GetCount();
            _fooMock.Object.GetCount();

            Assert.That(_fooMock.Object.GetCount(), Is.EqualTo(2));
        }

        [Test]
        public void Test_Exceptions_Argurments()
        {
            _fooMock.Setup(foo => foo.DoSomething("null")).Throws(new ArgumentException("cmd"));

            Assert.Throws<ArgumentException>(() =>
            {
                _fooMock.Object.DoSomething("null");
            }, "cmd");
        }

        [Test]
        public void Test_Property_Values()
        {
            _fooMock.Setup(foo => foo.Name).Returns("bar");
            _fooMock.Setup(foo => foo.SomeBaz.Name).Returns("hello");

            _fooMock.Object.Name = "This will not work??";

            Assert.Multiple(() =>
            {
                Assert.That(_fooMock.Object.Name, Is.EqualTo("bar"));
                Assert.That(_fooMock.Object.SomeBaz.Name, Is.EqualTo("hello"));
            });        
        }

        [Test]
        public void Test_Property_Values_That_Is_Set()
        {
            bool setterCalled = false;

            _fooMock.SetupSet(foo =>
            {
                foo.Name = It.IsAny<string>();
            }).Callback<string>(value =>
            {
                setterCalled = true;
            });

            _fooMock.Object.Name = "bob";

            _fooMock.VerifySet(foo =>
            {
                foo.Name = "bob";
            }, Times.AtLeastOnce);
        }
    }
}
