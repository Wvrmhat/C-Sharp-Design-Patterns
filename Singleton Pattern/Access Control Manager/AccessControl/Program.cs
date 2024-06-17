using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "";
          

            string authorise = "";
       //     int attemptNo = 0;

         //  Console.Write("Enter username: ");
          // user = Console.ReadLine();

            AccessControlManager Access = AccessControlManager.GetAccess();
        
            Access.Permission(user, authorise);
            Access.LogAttempts(user);

            Console.WriteLine("-----------------------------------------");

            Console.ReadLine();


            

        }

        public static void ManageSingleton()
        {
            AccessControlManager Access = AccessControlManager.GetAccess();
            
        }
    }
}
