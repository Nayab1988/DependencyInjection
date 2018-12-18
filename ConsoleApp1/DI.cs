using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DI
    {
    }
    public interface ICustormerDataAccess
    {
        void GetCustomerName(int id);
    }
    public class CustormerDataAccess : ICustormerDataAccess
    {
        public CustormerDataAccess()
        {

        }
        public void GetCustomerName(int id)
        {
            Console.WriteLine("Dummy Customer Data of " + id);
        }
    }
    
    public class CustomerBusinessLogic
    {
        public ICustormerDataAccess _obj;
        public CustomerBusinessLogic(ICustormerDataAccess obj)
        {
            _obj = obj;
        }
        public void GetCustomerData()
        {
            _obj.GetCustomerName(10);
        }
    }
}
