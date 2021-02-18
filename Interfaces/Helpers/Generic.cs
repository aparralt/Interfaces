using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Helpers
{
    class Generic : ILService
    {
        public string TypeOfService
        {
            get { return "External"; }
        }

        public int ID
        {
            get { return -1; }
        }

        public string GetServiceName()
        {
            return "Generic Services";
        }
    }
}
