using Bridges.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges.ApplicationServices.GetBridgePointListUseCase
{
    public class GetBridgePointListUseCaseRequest : IUseCaseRequest<GetBridgePointListUseCaseResponse>
    {
        public string Year { get; private set; }
        public long? BridgePointId { get; private set; }

        private GetBridgePointListUseCaseRequest()
        { }

        public static GetBridgePointListUseCaseRequest CreateAllBridgePointsRequest()
        {
            return new GetBridgePointListUseCaseRequest();
        }

        public static GetBridgePointListUseCaseRequest CreateBridgePointRequest(long bridgepointId)
        {
            return new GetBridgePointListUseCaseRequest() { BridgePointId = bridgepointId };
        }
        public static GetBridgePointListUseCaseRequest CreateOrganizationBridgePointsRequest(string year)
        {
            return new GetBridgePointListUseCaseRequest() { Year = year };
        }
    }
}
