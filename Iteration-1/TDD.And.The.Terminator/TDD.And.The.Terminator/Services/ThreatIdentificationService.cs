using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD.And.The.Terminator.Interfaces;
using TDD.And.The.Terminator.Model;
using TDD.And.The.Terminator.Models;
using TDD.And.The.Terminator.Rules;

namespace TDD.And.The.Terminator.Services
{
    class ThreatIdentificationService : IThreatIdentificationService
    {
        private readonly List<IThreatRule> _threatRules;
        public ThreatIdentificationService()
        {
            _threatRules = new List<IThreatRule>();
            _threatRules.Add(new IsBoyRule());
            _threatRules.Add(new IsGirlRule());
            _threatRules.Add(new IsWomanRule());
            _threatRules.Add(new IsManRule());
            _threatRules.Add(new IsCatRule());
            _threatRules.Add(new IsDogRule());
        }

        
        public bool InvestigateThreat(Threat threat)
        {
            var isMatch = _threatRules.FirstOrDefault(r => r.IsMatch(threat));
            return isMatch != null ? IndentifyAsHuman(isMatch) : true;
        }
        public bool IndentifyAsHuman(IThreatRule rule)
        {
            return rule.IsHuman();
        }
    }
}
