using System.Collections.Generic;

namespace MyFramework.IO.Domain.Test.FooClass
{
    public class Bar : ValueObject
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public List<SubBar> SubBars { get; set; }

        public Bar(int code, string name, List<SubBar> subBars)
        {
            this.Code = code;
            this.Name = name;
            this.SubBars = subBars;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
            yield return Name;

            foreach (var subBar in SubBars)
            {
                yield return subBar;
            }
        }
    }

    public class SubBar
    {
        public int SubCode { get; set; }
    }
}
