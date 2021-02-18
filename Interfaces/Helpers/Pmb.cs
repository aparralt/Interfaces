using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Helpers
{
    class Pmb : ILService
    {
        public string TypeOfService
        {
            get { return "Internal"; }
        }

        public int ID
        {
            get { return 0; }
        }

        public string GetServiceName()
        {
            return "PMB Services";
        }
    }
}
