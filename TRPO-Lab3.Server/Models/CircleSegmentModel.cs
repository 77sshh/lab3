using System.ComponentModel;

namespace TRPO_Lab3.Server.Models
{
    public class CircleSegmentModel
    {
        [DisplayName("Радиус")]
        public double radiu5 { get; set; }
        [DisplayName("Угол(градусы)")]
        public double angle { get; set; }
    }
}
