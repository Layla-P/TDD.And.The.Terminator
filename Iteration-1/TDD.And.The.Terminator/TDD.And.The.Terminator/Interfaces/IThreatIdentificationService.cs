using TDD.And.The.Terminator.Model;

namespace TDD.And.The.Terminator.Interfaces
{
    public interface IThreatIdentificationService
    {
        bool IndentifyAsHuman(string threat);
        Sex GetSexOfThreat();
        int GetAge();
    }
}