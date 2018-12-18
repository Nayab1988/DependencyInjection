using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DIP
    {
    }
    //public interface ICustormerDataAccess
    //{
    //    void GetCustomerName(int id);
    //}
    //public class CustormerDataAccess: ICustormerDataAccess
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
    //    public static ICustormerDataAccess CreateObject()
    //    {
    //        return new CustormerDataAccess();
    //    }
    //}
    //public class CustomerBusinessLogic
    //{
    //    public ICustormerDataAccess _obj;
    //    public CustomerBusinessLogic()
    //    {
    //        _obj = Factory.CreateObject(); //still we using Factory(concrete class),not loosecoupled yet.so we use DI to inject this object by using constructor,Property or Method.
    //    }
    //    public void GetCustomerData()
    //    {
    //        _obj.GetCustomerName(10);
    //    }
    //}
}
