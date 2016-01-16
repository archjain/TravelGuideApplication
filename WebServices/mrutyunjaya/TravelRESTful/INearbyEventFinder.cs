﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
namespace TravelRESTful
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INearbyEventFinder" in both code and config file together.
    [ServiceContract]
    public interface INearbyEventFinder
    {
        [OperationContract]
        [WebGet(UriTemplate = "{cityName}")]
        List<EventDetails> getCurrentEvents(string cityName);
    }
}
