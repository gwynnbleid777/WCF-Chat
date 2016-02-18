using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        string Say(string phrase);
    }
}
