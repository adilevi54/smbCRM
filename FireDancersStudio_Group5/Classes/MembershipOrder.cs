using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDancersStudio_Group5.Classes
{
    public class MembershipOrder
    {
        private string orderID;
        private string priceForCustomer;
        private string paymentConfirmation;
        private MembershipPackage package;
        private Customer customer;

        //Constructor
        public MembershipOrder(string orderID, string priceForCustomer, string paymentConfirmation,
            MembershipPackage package, Customer customer)
        {
            this.orderID = orderID;
            this.priceForCustomer = priceForCustomer;
            this.paymentConfirmation = paymentConfirmation;
            this.package = package;
            this.customer = customer;            
        }

        public string GetOrderID()
        {
            return this.orderID;
        }

        public string GetPriceForCustomer()
        {
            return this.priceForCustomer;
        }

        public string getPaymentConfirmation()
        {
            return this.paymentConfirmation;
        }

        public MembershipPackage GetPackage()
        {
            return this.package;
        }

        public Customer GetCustomer()
        {
            return this.customer;
        }

        public static List<MembershipOrder> showCustomersOrders(string customerID)
        {
            List<MembershipOrder> membershipOrderList = new List<MembershipOrder>();

            foreach (MembershipOrder mo in Program.MembershipOrders)
            {                
                //Check if the customer owns this order
                if (mo.GetCustomer().GetID().Equals(customerID))
                    membershipOrderList.Add(mo);                
            }

            return membershipOrderList;
        }

       public static List<MembershipPackage> showCustomersMissingPackages(string customerID)
       {
            //List<MembershipPackage> membershipPackagesAll = new List<MembershipPackage>();
            List<MembershipPackage> missingMembershipPackages = new List<MembershipPackage>();
            List<MembershipOrder> membershipOrders = new List<MembershipOrder>();
            bool flag = false;


            //foreach (MembershipPackage package in Program.MembershipPackages)
            //{
            //    membershipPackagesAll.Add(package);
            //}

            membershipOrders = showCustomersOrders(customerID);

            foreach (MembershipPackage mpa in Program.MembershipPackages)
            {
                foreach (MembershipOrder mo in membershipOrders)
                {
                    if (mpa.GetPackageName() == mo.GetPackage().GetPackageName())
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    missingMembershipPackages.Add(mpa);
                flag = false;
            }

            return missingMembershipPackages;
       }

        public void InsertNewOrder()
        {
            SQL_CON SC = new SQL_CON();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE dbo.SP_InsertMembershipOrder @orderID, @priceForCustomer, @paymentConfirmation, @packageName, @customerID";

            c1.Parameters.AddWithValue("@orderID", this.orderID);
            c1.Parameters.AddWithValue("@priceForCustomer", this.priceForCustomer);
            c1.Parameters.AddWithValue("@paymentConfirmation", this.paymentConfirmation);
            c1.Parameters.AddWithValue("@packageName", this.package.GetPackageName());
            c1.Parameters.AddWithValue("@customerID", this.customer.GetID());

            SC.execute_non_query(c1);

            Program.MembershipOrders.Add(this);
            Program.seekCustomer(this.customer.GetID()).InsertMembershipOrder(this);
        }
    }
}
