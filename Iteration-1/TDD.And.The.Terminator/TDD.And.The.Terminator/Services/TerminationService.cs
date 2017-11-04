
using TDD.And.The.Terminator.Interfaces;

namespace TDD.And.The.Terminator.Services
{
    public class TerminationService
    {
        private IThreatIdentificationService _threatIdentificationService;

        public TerminationService(IThreatIdentificationService threatIdentificationService) {
            _threatIdentificationService = threatIdentificationService;

        }

        public bool IfTargetHumanInvestigateFurther(string threat)
        {
            var result = _threatIdentificationService.IndentifyAsHuman(threat);
            return result;
        }
    }
}
