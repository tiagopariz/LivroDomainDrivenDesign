using System;
using System.Collections.Generic;

namespace UmDesignDirigidoPorModelos.Domain.Models
{
    public abstract class AbstractNet
    {
        private readonly List<LayoutRule> _rules;

        public AbstractNet()
        {
            _rules = new List<LayoutRule>();
        }

        public IReadOnlyCollection<LayoutRule> Rules => _rules;

        public void AssignRule(LayoutRule rule)
        {
            _rules.Add(rule);
        }

        public virtual List<LayoutRule> AssignedRules()
        {
            return _rules;
        }
    }
}
