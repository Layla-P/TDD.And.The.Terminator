using FluentAssertions;
using Moq;
using NUnit.Framework;
using TDD.And.The.Terminator.Interfaces;
using TDD.And.The.Terminator.Models;
using TDD.And.The.Terminator.Services;

namespace TDD.And.The.Terminator.Tests
{
    public static class TD
    {
        public static Threat DogThreat { get; set; } = new Threat { ThreatName = "dog" };
        public static Threat CatThreat { get; set; } = new Threat { ThreatName = "cat" };
        public static Threat GirlThreat { get; set; } = new Threat { ThreatName = "girl" };
        public static Threat BoyThreat { get; set; } = new Threat { ThreatName = "boy" };
        public static Threat ManThreat { get; set; } = new Threat { ThreatName = "man" };
        public static Threat WomanThreat { get; set; } = new Threat { ThreatName = "woman" };
        public static Threat GSDThreat { get; set; } = new Threat { ThreatName = "german shepherd dog" };
        public static Threat HoneyBadgerThreat { get; set; } = new Threat { ThreatName = "honey badger" };
    }
    [TestFixture]
    public class Terminator_Should
    {
        Mock<IThreatIdentificationService> mockThreatIdentificationService;
        TerminationService terminationService;


        [Test]
        public void BeTrueWithGirlThreat()
        {
            var girl = TD.GirlThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(girl)).Returns(true);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(girl);

            result.Should().BeTrue();

            mockThreatIdentificationService.VerifyAll();
        }
        [Test]
        public void BeTrueWithBoyThreat()
        {
            var boy = TD.BoyThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(boy)).Returns(true);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(boy);

            result.Should().BeTrue();

            mockThreatIdentificationService.VerifyAll();
        }
        [Test]
        public void BeTrueWithWomanThreat()
        {
            var woman = TD.WomanThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(woman)).Returns(true);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(woman);

            result.Should().BeTrue();

            mockThreatIdentificationService.VerifyAll();
        }
        [Test]
        public void BeTrueWithManThreat()
        {
            var man = TD.ManThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(man)).Returns(true);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(man);

            result.Should().BeTrue();

            mockThreatIdentificationService.VerifyAll();
        }
        [Test]
        public void BeFalseWithDogThreat()
        {
            var dog = TD.DogThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(dog)).Returns(false);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(dog);

            result.Should().BeFalse();

            mockThreatIdentificationService.VerifyAll();

        }
        [Test]
        public void BeFalseWithCatThreat()
        {
            var cat = TD.CatThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(cat)).Returns(false);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(cat);

            result.Should().BeFalse();

            mockThreatIdentificationService.VerifyAll();

        }
        [Test]
        public void BeTrueWithHoneyBadgerThreat()
        {
            var honeyBadger = TD.HoneyBadgerThreat;
            mockThreatIdentificationService = new Mock<IThreatIdentificationService>(MockBehavior.Strict);
            mockThreatIdentificationService.Setup(p => p.InvestigateThreat(honeyBadger)).Returns(true);

            terminationService = new TerminationService(mockThreatIdentificationService.Object);
            var result = terminationService.IfTargetHumanInvestigateFurther(honeyBadger);

            result.Should().BeTrue();

            mockThreatIdentificationService.VerifyAll();
        }
    }

}