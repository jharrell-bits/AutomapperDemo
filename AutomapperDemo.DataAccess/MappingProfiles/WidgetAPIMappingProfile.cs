using AutoMapper;
using AutomapperDemo.Models;

namespace AutomapperDemo.DataAccess.MappingProfiles
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
