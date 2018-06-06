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
        private Base64Field<TestsData, double[]> runtestsField;
        [NotMapped]
        public double[] RunTests
        {
            get
            {
                if (runtestsField == null)
                    runtestsField = new Base64Field<TestsData, double[]>(this, nameof(InnerRunTests));
                return runtestsField.Value;
            }
            set
            {
                if (runtestsField == null)
                    runtestsField = new Base64Field<TestsData, double[]>(this, nameof(InnerRunTests));
                runtestsField.Value = value;
            }
        }

        public string InnerTestPassedFlash { get; set; }
        private Base64Field<TestsData, double[]> testPassedFlashField;
        [NotMapped]
        public double[] TestPassedFlash
        {
            get
            {
                if (testPassedFlashField == null)
                    testPassedFlashField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedFlash));
                return testPassedFlashField.Value;
            }
            set
            {
                if (testPassedFlashField == null)
                    testPassedFlashField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedFlash));
                testPassedFlashField.Value = value;
            }
        }

        public string InnerTestPassedSound { get; set; }
        private Base64Field<TestsData, double[]> testPassedSoundField;
        [NotMapped]
        public double[] TestPassedSound
        {
            get
            {
                if (testPassedSoundField != null)
                    testPassedSoundField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedSound));
                return testPassedSoundField.Value;
            }
            set
            {
                if (testPassedSoundField != null)
                    testPassedSoundField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedSound));
                testPassedSoundField.Value = value;
            }
        }

        public string InnerTestPassedMotion { get; set; }
        private Base64Field<TestsData, double[]> testPassedMotionField;
        [NotMapped]
        public double[] TestPassedMotion
        {
            get
            {
                if (testPassedMotionField != null);
                    testPassedMotionField = new Base64Field<TestsData, double[]>(this, nameof(TestPassedMotion));
                return testPassedMotionField.Value;
            }
            set
            {
                if (testPassedMotionField != null) ;
                    testPassedMotionField = new Base64Field<TestsData, double[]>(this, nameof(TestPassedMotion));
                testPassedMotionField.Value = value;
            }
        }

        public string InnerTestPassedTapping { get; set; }
        private Base64Field<TestsData, double[]> testPassedTappingField;
        [NotMapped]
        public double[] TestPassedTapping
        {
            get
            {
                if (testPassedTappingField != null)
                    testPassedTappingField =  new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedTapping));
                return testPassedTappingField.Value;
            }
            set
            {
                if (testPassedTappingField != null)
                    testPassedTappingField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestPassedTapping));
                testPassedTappingField.Value = value;
            }
        }

        public string InnerTestDataTappingChernikova { get; set; }
        private Base64Field<TestsData, double[]> testDataTappingChernikovaField;
        [NotMapped]
        public double[] TestDataTappingChernikova
        {
            get
            {
                if (testDataTappingChernikovaField != null)
                    testDataTappingChernikovaField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestDataTappingChernikova));
                return testDataTappingChernikovaField.Value;
            }
            set
            {
                if (testDataTappingChernikovaField != null)
                    testDataTappingChernikovaField = new Base64Field<TestsData, double[]>(this, nameof(InnerTestDataTappingChernikova));
                testDataTappingChernikovaField.Value = value;
            }
        }

        public string InnerRusalovTest { get; set; }
        private Base64Field<TestsData, Dictionary<string, bool>> rusalovTestLazy;
        [NotMapped]
        public Dictionary<string, bool> RusalovTest
        {
            get
            {
                if (rusalovTestLazy != null)
                    rusalovTestLazy = new Base64Field<TestsData, Dictionary<string, bool>>(this, nameof(InnerRusalovTest));
                return rusalovTestLazy.Value;
            }
            set
            {
                if (rusalovTestLazy != null)
                    rusalovTestLazy = new Base64Field<TestsData, Dictionary<string, bool>>(this, nameof(InnerRusalovTest));
                rusalovTestLazy.Value = value;
            }
        }
    }
}
