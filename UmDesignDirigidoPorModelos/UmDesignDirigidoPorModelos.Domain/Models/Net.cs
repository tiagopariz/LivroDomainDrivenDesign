using System.Collections.Generic;
using System.Linq;

namespace UmDesignDirigidoPorModelos.Domain.Models
{
    public class Net : AbstractNet
    {
        private readonly Bus _bus;

        public Net(Bus bus)
        {
            _bus = bus;
        }

        public Net(string bus)
        {
            
        }

        public override List<LayoutRule> AssignedRules()
        {
            var result = new List<LayoutRule>();
            result.AddRange(base.Rules);
            result.AddRange(_bus.Rules);
            return result;
        }
    }
}