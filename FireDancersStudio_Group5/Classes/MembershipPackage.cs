using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5.Classes
{
    public class MembershipPackage
    {
        private string packageName;
        private string price;
        private ClassesLimitEnum classesLimitPerWeek;
        private CycleEnum paymentCycle;
        private List<MembershipOrder> orders;

        public MembershipPackage(string packageName, string price, ClassesLimitEnum classesLimitPerWeek,
            CycleEnum paymentCycle, List<MembershipOrder> orders)
        {
            this.packageName = packageName;
            this.price = price;
            this.classesLimitPerWeek = classesLimitPerWeek;
            this.paymentCycle = paymentCycle;
            this.orders = orders;
        }

        public string GetPackageName()
        {
            return this.packageName;
        }

        public string GetPrice()
        {
            return this.price;
        }

        public ClassesLimitEnum GetClassesLimitPerWeek()
        {
            return this.classesLimitPerWeek;
        }

        public CycleEnum GetPaymentCycle()
        {
            return this.paymentCycle;
        }

        public List<MembershipOrder> GetOrders()
        {
            return this.orders;
        }

        public void UpdateOrders()
        {
            List<MembershipOrder> orders = new List<MembershipOrder>();
            foreach (MembershipOrder mo in Program.MembershipOrders)
            {
                if (mo.GetPackage().GetPackageName().Equals(this.packageName))
                    orders.Add(mo);
            }
            this.orders = orders;
        }
    }
}
