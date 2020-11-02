using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.Foo
{
    public interface IAnimal
    {
        event EventHandler FallsIll;
        void Stumble();
    }
}
