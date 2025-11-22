using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console1
{
    public class Car
    {
        private string Name_;
        private double Speed_;

        public string GetModel()
        {
            return Name_;
        }
        public void SetModel(string Name)
        {
            Name_ = Name;
        }
    }
}
