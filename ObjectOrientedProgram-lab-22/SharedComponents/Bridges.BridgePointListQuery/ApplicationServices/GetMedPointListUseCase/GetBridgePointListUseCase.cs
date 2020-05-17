using System.Threading.Tasks;
using System.Collections.Generic;
using Bridges.DomainObjects;
using Bridges.DomainObjects.Ports;
using Bridges.ApplicationServices.Ports;

namespace Bridges.ApplicationServices.GetBridgePointListUseCase
{
    public class GetBridgePointListUseCase : IGetBridgePointListUseCase
    {
        private readonly IReadOnlyBridgePointRepository _readOnlyBridgePointRepository;

        public GetBridgePointListUseCase(IReadOnlyBridgePointRepository readOnlyBridgePointRepository) 
            => _readOnlyBridgePointRepository = readOnlyBridgePointRepository;

        public async Task<bool> Handle(GetBridgePointListUseCaseRequest request, IOutputPort<GetBridgePointListUseCaseResponse> outputPort)
        {
            IEnumerable<BridgePoint> bridgepoints = null;
            if (request.BridgePointId != null)
            {
                var bridgepoint = await _readOnlyBridgePointRepository.GetBridgePoint(request.BridgePointId.Value);
                bridgepoints = (bridgepoint != null) ? new List<BridgePoint>() { bridgepoint } : new List<BridgePoint>();
                
            }
            else if (request.Year != null)
            {
                bridgepoints = await _readOnlyBridgePointRepository.QueryBridgePoints(new YearCriteria(request.Year));
            }
            else
            {
                bridgepoints = await _readOnlyBridgePointRepository.GetAllBridgePoints();
            }
            outputPort.Handle(new GetBridgePointListUseCaseResponse(bridgepoints));
            return true;
        }
    }
}
