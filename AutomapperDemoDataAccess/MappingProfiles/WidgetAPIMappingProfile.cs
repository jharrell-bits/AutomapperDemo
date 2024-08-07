using AutoMapper;
using AutomapperDemoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
