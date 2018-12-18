using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Practices.Unity;
using Unity;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewClass obj1 = new NewClass();
            //NewClass obj2 = new NewClass();
            //NewClass obj3 = new NewClass();
            //NewClass obj4 = new NewClass();


            /* The below code has been used with UnityContainer
            CustomerBusinessLogic obj = new CustomerBusinessLogic(new CustormerDataAccess());//it's not satisfying Single Responsiblity rule of SOLID, 
            //so takecare of this we using IOC Container.for this I'm using UnityContainer.
            obj.GetCustomerData();*/
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICustormerDataAccess, CustormerDataAccess>();
            var obj=container.Resolve<CustomerBusinessLogic>();
            obj.GetCustomerData();
            Console.ReadLine();
        }
    }
    public class NewClass
    {
        private static int ObjCount = 0;
        public NewClass()
        {
            if(ObjCount >= 3)
            {
                try
                {
                    throw new Exception("You can't create more than 3 objects");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                ObjCount += 1;
                Console.WriteLine("Object " + ObjCount);
            }
        }
    }

   
}
