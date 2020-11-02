using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.Foo
{
    public class Consumer
    {
        private readonly IFoo foo;

        public Consumer(IFoo foo)
        {
            this.foo = foo;
        }

        public void Hello()
        {
            foo.DoSomething("ping");
            var name = foo.Name;
        }
    }
}
