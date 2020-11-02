using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.Foo
{
    public class Doctor
    {
        public int TimesCured;
        public Doctor(IAnimal animal)
        {
            animal.FallsIll += Animal_FallsIll;
        }

        private void Animal_FallsIll(object sender, EventArgs e)
        {
            Console.WriteLine("I will cure you!");
            TimesCured++;
        }
    }
}
