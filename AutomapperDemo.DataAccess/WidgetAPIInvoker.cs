using AutoMapper;
using AutomapperDemo.DataAccess.MappingProfiles;
using AutomapperDemo.Models;

namespace AutomapperDemo.DataAccess
{
    public class WidgetAPIInvoker : IWidgetAPIInvoker
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public WidgetAPIInvoker(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // set the Automapper configuration profile that should be used for this WebAPI Invoker class
            var config = new MapperConfiguration(cfg => cfg.AddProfile<WidgetAPIMappingProfile>());
            _mapper = new Mapper(config);
        }

        public async Task<List<Widget>> GetWidgets()
        {
            // create a WebAPI client
            var widgetAPI = new WidgetWebAPI.WidgetWebAPI("https://localhost:44317", _httpClient);

            // fetch the data
            var widgets = await widgetAPI.GetWidgetsAsync();

            // use Automapper to convert the list of WidgetWebAPI.Widget objects to a list of AutomapperDataAccess.Models.Widget objects
            return _mapper.Map<List<Widget>>(widgets);
        }
    }
}
