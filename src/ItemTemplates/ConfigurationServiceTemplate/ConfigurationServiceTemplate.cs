using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using Terrasoft.Web.Common;

namespace $rootnamespace$
{
    #region Class: $safeitemrootname$

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class $safeitemrootname$: BaseService
    {
        #region Methods: Public

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
                    ResponseFormat = WebMessageFormat.Json)]
        public $safeitemrootname$Response GlbMethod1($safeitemrootname$Request request)
        {
            var response = new $safeitemrootname$Response();

            //TODO your business logic

            return response;
        }

        #endregion
    }

    #endregion

    #region Class: $safeitemrootname$Request
    
    [DataContract]
    public class $safeitemrootname$Request
    {
        [DataMember]
        public Guid RecordId { get; set; }
    }

    #endregion

    #region Class: $safeitemrootname$Response

    [DataContract]
    public class $safeitemrootname$Response
    {
        [DataMember]
        public bool IsSuccess { get; set; }
    }

    #endregion
}
