using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vai.Data.Models
{
    public class TestsData
    {

        public Guid Id { get; set; }

        [ForeignKey(nameof(Research))]
        public Guid ResearchId { get; set; }
        public Research Research { get; set; }

        public string InnerRunTests { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> runtestsLazy;
        [NotMapped]
        public Base64Field<TestsData, double[]> RunTests
        {
            get
            {
                if (runtestsLazy != null) return runtestsLazy.Value;
                runtestsLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerRunTests)));
                return runtestsLazy.Value;
            }
        }

        public string InnerTestPassedFlash { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedFlashLazy;
        [NotMapped]
        public Base64Field<TestsData, double[]> TestPassedFlash
        {
            get
            {
                if (testPassedFlashLazy != null) return runtestsLazy.Value;
                testPassedFlashLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedFlash)));
                return testPassedFlashLazy.Value;
            }
        }

        public string InnerTestPassedSound { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedSoundLazy;
        [NotMapped]
        public Base64Field<TestsData, double[]> TestPassedSound
        {
            get
            {
                if (testPassedSoundLazy != null) return testPassedSoundLazy.Value;
                testPassedSoundLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedSound)));
                return testPassedSoundLazy.Value;
            }
        }

        public string InnerTestPassedMotion { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedMotionLazy;
        [NotMapped]
        public Base64Field<TestsData, double[]> TestPassedMotion
        {
            get
            {
                if (testPassedMotionLazy != null) return testPassedMotionLazy.Value;
                testPassedMotionLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(TestPassedMotion)));
                return testPassedMotionLazy.Value;
            }
        }

        public string InnerTestPassedTapping { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testPassedTappingLazy;
        [NotMapped]
        public Base64Field<TestsData, double[]> TestPassedTapping
        {
            get
            {
                if (testPassedTappingLazy != null) return testPassedTappingLazy.Value;
                testPassedTappingLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedTapping)));
                return testPassedTappingLazy.Value;
            }
        }

        public string InnerTestDataTappingChernikova { get; set; }
        private Lazy<Base64Field<TestsData, double[]>> testDataTappingChernikovaLazy;
        [NotMapped]
        public Base64Field<TestsData, double[]> TestDataTappingChernikova
        {
            get
            {
                if (testDataTappingChernikovaLazy != null) return testDataTappingChernikovaLazy.Value;
                testDataTappingChernikovaLazy = new Lazy<Base64Field<TestsData, double[]>>(
                    () => new Base64Field<TestsData, double[]>(this, nameof(InnerTestDataTappingChernikova)));
                return testPassedTappingLazy.Value;
            }
        }

        public string InnerRusalovTest { get; set; }
        private Lazy<Base64Field<TestsData, Dictionary<string, bool>>> rusalovTestLazy;
        [NotMapped]
        public Base64Field<TestsData, Dictionary<string, bool>> RusalovTest
        {
            get
            {
                if (rusalovTestLazy != null) return rusalovTestLazy.Value;
                rusalovTestLazy = new Lazy<Base64Field<TestsData, Dictionary<string, bool>>>(
                    () => new Base64Field<TestsData, Dictionary<string, bool>>(this, nameof(InnerRusalovTest)));
                return rusalovTestLazy.Value;
            }
        }
    }
}
