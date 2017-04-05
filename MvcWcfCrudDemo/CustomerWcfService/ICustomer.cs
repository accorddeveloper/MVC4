using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomerWcfService
{
    
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        void Save(Customer obj);

        [OperationContract]
        void Delete(string Id);

        [OperationContract]
        List<Customer> GetCustomer();

    }


   
}
