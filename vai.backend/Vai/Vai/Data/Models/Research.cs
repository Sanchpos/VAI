using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models.Enums;

namespace Vai.Data.Models
{
    public class Research
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        public DateTime CreatedOn { get; set; }

        [Display(Name = "Курящий")]
        public bool IsSmoking { get; set; }
        [Display(Name = "Курящий")]
        public bool IsDrinkingAlco { get; set; }

        [Display(Name = "Гемоглобин")]
        public double Hemoglobin { get; set; }
        [Display(Name = "Белые кровяные клетки")]
        public double WhiteBloodCells { get; set; }
        [Display(Name = "Красные кровяные клетки")]
        public double RedBloodCells { get; set; }
        [Display(Name = "Тромбоциты")]
        public double Platelets { get; set; }
        [Display(Name = "Средний объем клеток крови")]
        public double MeanCellVolume => Hemoglobin / RedBloodCells;

        public double Glucose { get; set; }
        public double Cholestirol { get; set; }

        public double Height { get; set; }
        public double Weight { get; set; }
        public double HandsLength { get; set; }
        public double SpineFrontwisePitch { get; set; }
        public double SpineRewardPitch { get; set; }
        public SomatoType Somatype { get; set; }
        public Posture Posture { get; set; }

        public double CircumFenceHead { get; set; }
        public double CircumFenceNeck { get; set; }
        public double CircumFenceArm { get; set; }
        public double CircumFenceChest { get; set; }
        public double CircumFenceWaist { get; set; }
        public double CircumFenceThigh { get; set; }
        public double CircumFenceCrus { get; set; }

        public double SkinfoldsBiceps { get; set; }
        public double SkinfoldsTriceps { get; set; }
        public double Skinfolds6Edge { get; set; }
        public double SkinfoldsAbdominal { get; set; }
        public double SkinfoldsSubscapular { get; set; }
        public double SkinfoldsThigh { get; set; }
        public double SkinfoldsCrus { get; set; }

        public double LungsCapacity { get; set; }

        public double DynamometyLeftHand { get; set; }
        public double DynamometyRightHand { get; set; }
        public double DynamometySpine { get; set; }

        public double HeartRateRest { get; set; }
        public double HeartRateTotalRest { get; set; }

        public double BloodPressureSystolic { get; set; }
        public double BloodPressureDiastolic { get; set; }

        public double HypoxicTestInspiration { get; set; }
        public double HypoxicTestExpiration { get; set; }

        public ICollection<SportResearch> Sports { get; set; }

        [ForeignKey(nameof(TestsData))]
        public Guid TestDataId { get; set; }
        public TestsData TestDataInternal { get; set; }
        [NotMapped]
        public ITestData TestData => TestDataInternal;

        public double PullUpStandart { get; set; }
        public double Pushes { get; set; }
        public double Swiming50 { get; set; }
        public double Shooting25 { get; set; }
        public double Jumping { get; set; }

        public double JumpingLong { get; set; }
        public double Shooting50 { get; set; }
        public double Swiming100 { get; set; }
        public double BallTrowing { get; set; }
        public double GrenadeTrowing { get; set; }
    }

    public class SportResearch
    {
        public Guid ResearchId { get; set; }
        public Research Research { get; set; }
        public Guid SportId { get; set; }
        public Sport Sport { get; set; }
    }
}
