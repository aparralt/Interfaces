using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface ILService

    {
        string TypeOfService { get; }
        int ID { get; }
        string GetServiceName();        
    }
}
