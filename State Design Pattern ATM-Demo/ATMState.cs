using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern_ATM_Demo
{
    public abstract class ATMState
    {
        public abstract void InsertCard(ATMMachine context);
        public abstract void EjectCard(ATMMachine context);
        public abstract void InsertPin(ATMMachine context, int pin);
        public abstract void RequestCash(int cashToWithdraw,ATMMachine context);

    }
}
