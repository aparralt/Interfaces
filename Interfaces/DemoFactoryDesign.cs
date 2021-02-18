using Interfaces.Helpers;
using Interfaces.Interfaces;
using System;

namespace Interfaces
{
    public class DemoFactoryDesign
    {
        static void Main(string[] args)
        {
        }
        public static ILService GetServiceInstace(int ID)
        {
            switch (ID)
            {
                case 0: return new Pmb();
                case 1: return new Dedicated();
                default: return new Generic();
            }
        }
    }
}
