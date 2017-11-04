
using TDD.And.The.Terminator.Interfaces;
using TDD.And.The.Terminator.Models;

namespace TDD.And.The.Terminator.Services
{
    public class TerminationService
    {
        private IThreatIdentificationService _threatIdentificationService;

        public TerminationService(IThreatIdentificationService threatIdentificationService) {
            _threatIdentificationService = threatIdentificationService;

        }

        public bool IfTargetHumanInvestigateFurther(Threat threat)
        {
            var result = _threatIdentificationService.InvestigateThreat(threat);
            return result;
        }
    }
}
