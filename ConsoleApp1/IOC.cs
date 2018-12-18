using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IOC
    {
    }
    //public class CustormerDataAccess
    //{
    //    public CustormerDataAccess()
    //    {

    //    }
    //    public void GetCustomerName(int id)
    //    {
    //        Console.WriteLine("Dummy Customer Data of " + id);
    //    }
    //}
    //public class Factory
    //{
    //    public static CustormerDataAccess CreateObject()
    //    {
    //        return new CustormerDataAccess();
    //    }
    //}
    //public class CustomerBusinessLogic
    //{
    //    CustormerDataAccess obj= Factory.CreateObject();
    //    //We can achive IOC here, but it's not fully loosely coupled. so we implement DIP, DIP says high level modules shouldn't depend on low level module,
    //    //Both should depend on abstraction, Abstraction shouldn't depend on details,details should depend on abstraction. for this need to create interface.
    //    public void GetCustomerData()
    //    {
    //        obj.GetCustomerName(10);
    //    }
    //}
}
