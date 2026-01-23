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
        private string fotocartochka_;

        public Students()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }

        public string Name
        {
            get{ return name_; }
        }

        public string Age
        {
            get { return Convert.ToString(age_); }
        }

        public string Args
        {
            get { return Convert.ToString(args_); }
        }

        public string Number
        {
            get { return Convert.ToString(number_); }
        }
        public string Fotokartochka
        {
            get { return Convert.ToString(fotocartochka_); }
        }

        public Students(string name, int age, double args, int number, string fotocartochka)
        {
            this.name_ = name;
            this.age_ = age;
            this.args_ = args;
            this.number_ = number;
            this.fotocartochka_ = fotocartochka;
        }
    }
}
