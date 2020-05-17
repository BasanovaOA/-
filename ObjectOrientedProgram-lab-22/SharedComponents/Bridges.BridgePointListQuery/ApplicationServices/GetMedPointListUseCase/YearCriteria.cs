using Bridges.DomainObjects;
using Bridges.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bridges.ApplicationServices.GetBridgePointListUseCase
{
    public class YearCriteria : ICriteria<BridgePoint>
    {
        public string Year { get; }

        public YearCriteria(string year)
            => Year = year;

        public Expression<Func<BridgePoint, bool>> Filter
            => (bp => bp.Year == Year);
    }
}
