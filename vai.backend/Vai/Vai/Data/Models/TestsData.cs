using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vai.Data.Models
{
    public class TestsData : ITestData
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Research))]
        public Guid ResearchId { get; set; }
        public Research Research { get; set; }

        public string InnerRunTests { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> runtestsLazy;
        [NotMapped]
        public double[] RunTests
        {
            get
            {
                if (runtestsLazy != null) return runtestsLazy.Value.Value;
                runtestsLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerRunTests)));
                return runtestsLazy.Value.Value;
            }
        }

        public string InnerTestPassedFlash { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedFlashLazy;
        [NotMapped]
        public double[] TestPassedFlash
        {
            get
            {
                if (testPassedFlashLazy != null) return runtestsLazy.Value.Value;
                testPassedFlashLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedFlash)));
                return testPassedFlashLazy.Value.Value;
            }
        }

        public string InnerTestPassedSound { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedSoundLazy;
        [NotMapped]
        public double[] TestPassedSound
        {
            get
            {
                if (testPassedSoundLazy != null) return testPassedSoundLazy.Value.Value;
                testPassedSoundLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedSound)));
                return testPassedSoundLazy.Value.Value;
            }
        }

        public string InnerTestPassedMotion { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedMotionLazy;
        [NotMapped]
        public double[] TestPassedMotion
        {
            get
            {
                if (testPassedMotionLazy != null) return testPassedMotionLazy.Value.Value;
                testPassedMotionLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(TestPassedMotion)));
                return testPassedMotionLazy.Value.Value;
            }
        }

        public string InnerTestPassedTapping { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedTappingLazy;
        [NotMapped]
        public double[] TestPassedTapping
        {
            get
            {
                if (testPassedTappingLazy != null) return testPassedTappingLazy.Value.Value;
                testPassedTappingLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedTapping)));
                return testPassedTappingLazy.Value.Value;
            }
        }

        public string InnerTestDataTappingChernikova { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testDataTappingChernikovaLazy;
        [NotMapped]
        public double[] TestDataTappingChernikova
        {
            get
            {
                if (testDataTappingChernikovaLazy != null) return testDataTappingChernikovaLazy.Value.Value;
                testDataTappingChernikovaLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestDataTappingChernikova)));
                return testPassedTappingLazy.Value.Value;
            }
        }

        public string InnerRusalovTest { get; set; }
        private Lazy<Base64Field<TestsData, Dictionary<string, bool>>> rusalovTestLazy;
        [NotMapped]
        public Dictionary<string, bool> RusalovTest
        {
            get
            {
                if (rusalovTestLazy != null) return rusalovTestLazy.Value.Value;
                rusalovTestLazy = new Lazy<Base64Field<TestsData, Dictionary<string, bool>>>(
                    () => new Base64Field<TestsData, Dictionary<string, bool>>(this, nameof(InnerRusalovTest)));
                return rusalovTestLazy.Value.Value;
            }
        }
    }
}
