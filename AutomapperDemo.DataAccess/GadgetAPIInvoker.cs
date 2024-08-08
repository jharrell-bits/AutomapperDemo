using AutoMapper;
using AutomapperDemo.DataAccess.MappingProfiles;
using AutomapperDemo.Models;

namespace AutomapperDemo.DataAccess
{
    public class GadgetAPIInvoker : IGadgetAPIInvoker
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public GadgetAPIInvoker(HttpClient httpClient) 
        {
            _httpClient = httpClient;

            // set the Automapper configuration profile that should be used for this WebAPI Invoker class
            var config = new MapperConfiguration(cfg => cfg.AddProfile<GadgetAPIMappingProfile>());
            _mapper = new Mapper(config);
        }

        public async Task<List<Gadget>> GetGadgets()
        {
            // create a WebAPI client
            var gadgetAPI = new GadgetWebAPI.GadgetWebAPI("https://localhost:44373", _httpClient);

            // fetch the data
            var gadgets = await gadgetAPI.GetGadgetsAsync();

            // use Automapper to convert the list of GadgetWebAPI.Gadget objects to a list of AutomapperDataAccess.Models.Gadget objects
            return _mapper.Map<List<Gadget>>(gadgets);
        }
    }
}
