using AutoMapper;
using AutomapperDemoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
