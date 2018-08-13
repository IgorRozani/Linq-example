using System.Collections.Generic;
using System.Linq;

namespace LinqExamples.Model
{
    public class Pokemon
    {
        public Pokemon(int number, string name, params TypeEnum[] type)
        {
            Number = number;
            Name = name;
            Type = type.ToList();
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public List<TypeEnum> Type { get; set; }
    }
}
