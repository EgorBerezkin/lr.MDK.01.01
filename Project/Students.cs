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



        public string Name
        {
            get{ return name_; }
        }

        public int Age
        {
            get { return age_; }
        }

        public double Args
        {
            get { return args_; }
        }

        public int Number
        {
            get { return number_; }
        }
        public string Fotokartochka
        {
            get { return fotocartochka_; }
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
