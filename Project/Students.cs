using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Students
    {
        private string name_;
        private int age_;
        private double args_;
        private int number_;

        public Students()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }

        public string GetName()
        {
            return name_;
        }

        public Students(string name_, int age_, double args_, int number_)
        {
            this.name_ = name_;
            this.age_ = age_;
            this.args_ = args_;
            this.number_ = number_;
        }
    }
}
