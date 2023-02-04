using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeApp
{
    public class Statistics
    {
        public float Max { get; set; }
        public float Min { get; set; }
        public float Average { get; set; }
        public char AverageLetter { get; set; }
        public float QuantityGrades { get; set; }
    }
}
