using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Bridges.DomainObjects.Ports
{
    public interface IReadOnlyBridgePointRepository
    {
        Task<BridgePoint> GetBridgePoint(long id);

        Task<IEnumerable<BridgePoint>> GetAllBridgePoints();

        Task<IEnumerable<BridgePoint>> QueryBridgePoints(ICriteria<BridgePoint> criteria);

    }

    public interface IBridgePointRepository

    {
        Task AddBridgePoint(BridgePoint bridgepoint);

        Task RemoveBridgePoint(BridgePoint bridgepoint);

        Task UpdateBridgePoint(BridgePoint bridgepoint);
    }
}
