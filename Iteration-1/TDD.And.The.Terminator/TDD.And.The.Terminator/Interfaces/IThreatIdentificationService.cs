using TDD.And.The.Terminator.Model;
using TDD.And.The.Terminator.Models;
using TDD.And.The.Terminator.Rules;

namespace TDD.And.The.Terminator.Interfaces
{
    public interface IThreatIdentificationService
    {
        bool InvestigateThreat(Threat threat);
        bool IndentifyAsHuman(IThreatRule rule);
    }
}