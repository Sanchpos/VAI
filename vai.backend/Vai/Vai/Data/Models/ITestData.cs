using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vai.Data.Models
{
    public interface ITestData
    {
        Guid Id { get; set; }
        Guid ResearchId { get; set; }
        Research Research { get; set; }

        double[] RunTests { get; set; }
        double[] TestPassedFlash { get; set; }
        double[] TestPassedSound { get; set; }
        double[] TestPassedMotion { get; set; }
        double[] TestPassedTapping { get; set; }
        double[] TestDataTappingChernikova { get; set; }
        Dictionary<string, bool> RusalovTest { get; set; }
    }
}
