using AutoMapper;
using AutomapperDemo.Models;

namespace AutomapperDemo.DataAccess.MappingProfiles
{
    public class GadgetAPIMappingProfile : Profile
    {
        public GadgetAPIMappingProfile()
        {
            CreateMap<GadgetWebAPI.Gadget, Gadget>()
                .ForMember(d => d.Key, opt => opt.MapFrom(s => s.GadgetKey));
        }
    }
}
