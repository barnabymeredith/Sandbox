using AutoMapper;
using Sandbox.DataAccessLayer.Models;
using Sandbox.Model.Characters;
using Sandbox.Model.Equipment.Weapons;

namespace Sandbox.Data.MappingProfiles
{
    public class SandboxMappingProfile : Profile
    {
        public SandboxMappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Spear, SpearDbo>();
            CreateMap<Spearman, SpearmanDbo>();
        }
    }
}
