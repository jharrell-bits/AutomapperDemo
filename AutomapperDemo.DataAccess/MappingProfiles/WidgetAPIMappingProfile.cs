using AutoMapper;
using AutomapperDemoModels;

namespace AutomapperDemoDataAccess.MappingProfiles
{
    public class WidgetAPIMappingProfile : Profile
    {
        public WidgetAPIMappingProfile()
        {
            CreateMap<WidgetWebAPI.Widget, Widget>()
                .ForMember(d => d.Cost, opt => opt.MapFrom(s => s.Price));
        }
    }
}
