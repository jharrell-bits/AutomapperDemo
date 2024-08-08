using AutoMapper;
using AutomapperDemoDataAccess.MappingProfiles;
using AutomapperDemoModels;

namespace AutomapperDemoDataAccess
{
    public class WidgetAPIInvoker : IWidgetAPIInvoker
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public WidgetAPIInvoker(HttpClient httpClient)
        {
            _httpClient = httpClient;

            var config = new MapperConfiguration(cfg => cfg.AddProfile<WidgetAPIMappingProfile>());
            _mapper = new Mapper(config);
        }

        public async Task<List<Widget>> GetWidgets()
        {
            var widgetAPI = new WidgetWebAPI.WidgetWebAPI("https://localhost:44317", _httpClient);

            var widgets = await widgetAPI.GetWidgetsAsync();

            return _mapper.Map<List<Widget>>(widgets);
        }
    }
}
