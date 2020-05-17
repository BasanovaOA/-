using Bridges.DomainObjects;
using Bridges.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridges.ApplicationServices.GetBridgePointListUseCase
{
    public class GetBridgePointListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<BridgePoint> BridgePoints { get; }

        public GetBridgePointListUseCaseResponse(IEnumerable<BridgePoint> bridgepoints) => BridgePoints = bridgepoints;
    }
}
