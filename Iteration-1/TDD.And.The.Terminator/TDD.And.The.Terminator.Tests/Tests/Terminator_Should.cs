using FluentAssertions;
using Moq;
using NUnit.Framework;
using TDD.And.The.Terminator.Interfaces;
using TDD.And.The.Terminator.Services;

namespace TDD.And.The.Terminator.Tests
{
    [TestFixture]
    public class Terminator_Should
    {
        Mock<IThreatIdentificationService> mockThreatIdentificationService;
        TerminationService terminationService;

        [TestCase("dog", false, false)]
        [TestCase("human", true, true)]
        [TestCase("honey badger", false, true)] //unidentified so should investigate
        public void Investigate_Target(string threat, bool expectedResult, bool shouldInvestigateFurther)
        {
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.IndentifyAsHuman(threat)).Returns(expectedResult);


            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(threat);

            result.Should().Be(shouldInvestigateFurther);

            mockThreatIdentificationService.VerifyAll();
        }
        
    }
}