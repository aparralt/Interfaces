using Interfaces;
using Interfaces.Interfaces;
using System;

namespace ClientProgram
{
    class Program
    {
        static void Main()
        {
            ILService pmb = DemoFactoryDesign.GetServiceInstace(0);
            pmb.GetServiceName();
            Console.WriteLine(pmb.GetServiceName());

            ILService dedicated = DemoFactoryDesign.GetServiceInstace(1);
            dedicated.GetServiceName();
            Console.WriteLine(dedicated.GetServiceName());

            ILService generic = DemoFactoryDesign.GetServiceInstace(3);
            generic.GetServiceName();
            Console.WriteLine(generic.GetServiceName());
        }
    }
}
