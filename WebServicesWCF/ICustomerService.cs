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
        [WebInvoke(Method = "POST", UriTemplate = "/Customer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Customer Add(Customer customer);

        [OperationContract]
        //[WebInvoke(Method = "PUT", UriTemplate = "/customer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int Update(Customer customer);

        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "/customer")]
        int Delete(Customer customer);


        [OperationContract]
        //[WebGet(UriTemplate="/id")]
        Customer Get(int id);

        [OperationContract]
        [WebGet]
        IEnumerable<Customer> GetAll();

    }
}
