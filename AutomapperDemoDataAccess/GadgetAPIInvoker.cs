using AutoMapper;
using AutomapperDemoDataAccess.MappingProfiles;
using AutomapperDemoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperDemoDataAccess
{
    public class GadgetAPIInvoker : IGadgetAPIInvoker
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public GadgetAPIInvoker(HttpClient httpClient) 
        {
            _httpClient = httpClient;

            var config = new MapperConfiguration(cfg => cfg.AddProfile<GadgetAPIMappingProfile>());
            _mapper = new Mapper(config);
        }

        public async Task<List<Gadget>> GetGadgets()
        {
            var gadgetAPI = new GadgetWebAPI.GadgetWebAPI("https://localhost:44373", _httpClient);

            var gadgets = await gadgetAPI.GetGadgetsAsync();

            return _mapper.Map<List<Gadget>>(gadgets);
        }
    }
}
