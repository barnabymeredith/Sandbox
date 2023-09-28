using System.ComponentModel.DataAnnotations;

namespace Sandbox.DataAccessLayer.Models
{
    public class SpearmanDbo
    {
        [Key]
        public int SpearmanId { get; set; }
        public int HealthPoints { get; set; }

        public List<SpearDbo> Spears { get; } = new();
    }
}
