using Sandbox.Model.Equipment.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sandbox.DataAccessLayer.Models
{
    public class SpearDbo
    {
        [Key]
        public int SpearId { get; set; }
        public Material Material { get; set; }
    }
}
