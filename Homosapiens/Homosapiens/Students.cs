using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homosapiens
{
    public class Students : Homosapiens
    {
        private int numberTicket_;
        public Students(int numberTicket) : base (22, "Наталья Дайер")
        {
            numberTicket_ = numberTicket;

        }
        public int NumberTicket
        {
            get { return numberTicket_; }
        }
        public override string ToString()
        {
            return base.ToString() + ", номер билета: " + numberTicket_;
        }
    }
}
