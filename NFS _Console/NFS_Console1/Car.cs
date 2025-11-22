using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console1
{
    public class Car
    {
        private string model_;
        private double speed_;
        // Наименование
        public string GetModel()
        {
            return model_;
        }
        public void SetModel(string model)
        {
            model_ = model;
        }
        // Скорость
        public double GetSpeed()
        {
            return speed_;
        }
        public void SetSpeed (double speed)
        {
            speed_ = speed;
        }
    }
}
