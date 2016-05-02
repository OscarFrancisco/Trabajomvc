using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServicesWCF
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Customer/{customer}")]
        Customer Add(Customer customer);

        [OperationContract]
        int Update(Customer customer);

        [OperationContract]
        int Delete(Customer customer);


        [OperationContract]
        [WebGet(UriTemplate = "Customer/{id}")]
        Customer Get(int id);

        [OperationContract]
        [WebGet]
        IEnumerable<Customer> GetAll(string nombre);

    }
}
