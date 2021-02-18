using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Helpers
{
    class Dedicated : ILService
    {
        public string TypeOfService
        {
            get { return "Internal"; }
        }

        public int ID
        {
            get { return 1; }
        }

        public string GetServiceName()
        {
            return "Dedicated Services";
        }
    }
}
