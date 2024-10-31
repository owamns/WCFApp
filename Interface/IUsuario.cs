using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using static DataAccess.DOUsuario;

namespace Interface
{
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ObtenerUsuario/{id}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Usuario ObtenerUsuario(string id);
    }
}
