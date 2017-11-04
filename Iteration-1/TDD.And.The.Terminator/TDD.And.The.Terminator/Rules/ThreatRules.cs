using System;
using System.Collections.Generic;
using System.Text;
using TDD.And.The.Terminator.Models;

namespace TDD.And.The.Terminator.Rules
{
    public interface IThreatRule
    {
        bool IsMatch(Threat threat);
        bool IsHuman();
    }
    public class IsDogRule : IThreatRule
    {
        public bool IsHuman()
        {
            return false;
        }

        public bool IsMatch(Threat threat)
        {
            return threat.ThreatName.ToLower().Contains("dog");
        }

    }
    public class IsCatRule : IThreatRule
    {
        public bool IsHuman()
        {
            return false;
        }

        public bool IsMatch(Threat threat)
        {
            return threat.ThreatName.ToLower().Contains("cat");
        }
    }
    public class IsWomanRule : IThreatRule
    {
        public bool IsHuman()
        {
            return true;
        }

        public bool IsMatch(Threat threat)
        {
            return threat.ThreatName.ToLower().Contains("woman");
        }
    }
    public class IsManRule : IThreatRule
    {
        public bool IsHuman()
        {
            return true;
        }

        public bool IsMatch(Threat threat)
        {
            return threat.ThreatName.ToLower().Contains("man") && !threat.ThreatName.ToLower().Contains("wo");
        }
    }
    public class IsGirlRule : IThreatRule
    {
        public bool IsHuman()
        {
            return true;
        }

        public bool IsMatch(Threat threat)
        {
            return threat.ThreatName.ToLower().Contains("girl");
        }
    }
    public class IsBoyRule : IThreatRule
    {
        public bool IsHuman()
        {
            return true;
        }

        public bool IsMatch(Threat threat)
        {
            return threat.ThreatName.ToLower().Contains("boy");
        }
    }

}
