using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homosapiens
{
    public class Homosapiens
    {
        protected int age_;
        protected string name_;
        public Homosapiens(int age, string name)
        {
            age_ = age;
            name_ = name;
        }

        public string GetName()
        {
            return name_;
        }
        public override string ToString()
        {
            return $"{GetName()}, {age_} лет";
        }
    }
}
