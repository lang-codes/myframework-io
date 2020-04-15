using System;

namespace MyFramework.IO.Domain.Test.MockClass
{
    public class Foo: Entity
    {
        public string Description { get; set; }

        public Foo(string description)
        {
            this.Description = description;
        }
    }
}
