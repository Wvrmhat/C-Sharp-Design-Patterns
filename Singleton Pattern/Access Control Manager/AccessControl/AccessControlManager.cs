using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    public sealed class AccessControlManager
    {
        private volatile static AccessControlManager _instance;
        private static readonly object _lockthis = new object();
        private AccessControlManager() { }
        //string user;

        public string Permission(string user,string authorize)
        {

            //user = "";
            Console.Write("Enter username: "); user = Console.ReadLine();


            if (user == "Max")
            {
                Console.WriteLine("Authorized user");
                authorize = Console.ReadLine();
                return authorize;
              

            }
            else
            {

                Console.WriteLine("Unauthorized user.");
                authorize = Console.ReadLine();
                return authorize;
            }
        }

        public void LogAttempts(string user)
        {
           // user = "";
            int attemptNo = 0;

            do
            {
                attemptNo++;
                Console.Write("Re-enter username: ");
                user = Console.ReadLine();



                if (user != "Max")
                {
                    Console.WriteLine("Invalid user. Attempt {0}", attemptNo);
                }

                if (attemptNo > 5)
                {
                    Console.WriteLine("{0}... you have been locked out of the system.", user);
                    break;
                } 

            } while (user != "Max");
        }

        public static AccessControlManager GetAccess()
        {
            if(_instance == null)
            {
                lock(_lockthis)
                {
                    if(_instance == null)
                    {
                        _instance = new AccessControlManager();
                    }
                }
            }
            return _instance;
        }
    }
}
