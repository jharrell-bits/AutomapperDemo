using AutoMapper;
using AutomapperDemoModels;

namespace AutomapperDemoDataAccess.MappingProfiles
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
