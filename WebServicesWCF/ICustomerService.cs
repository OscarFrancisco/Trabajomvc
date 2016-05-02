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
        [WebInvoke(Method = "POST", UriTemplate = "Post", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Customer Add(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Put")]
        int Update(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Delete/{id}")]
        int Delete(string id);


        [OperationContract]
        [WebGet(UriTemplate = "Get/{id}")]
        Customer Get(string id);

        [OperationContract]
        [WebGet(UriTemplate="GetAll")]
        IEnumerable<Customer> GetAll();

    }
}
