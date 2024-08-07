using AutomapperDemoDataAccess;
using AutomapperDemoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutomapperDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGadgetAPIInvoker _gadgetAPIInvoker;
        private readonly IWidgetAPIInvoker _widgetAPIInvoker;

        public List<Gadget> Gadgets { get; set; }
        public List<Widget> Widgets { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IGadgetAPIInvoker gadgetAPIInvoker, IWidgetAPIInvoker widgetAPIInvoker)
        {
            _logger = logger;
            _gadgetAPIInvoker = gadgetAPIInvoker;
            _widgetAPIInvoker = widgetAPIInvoker;
        }

        public async Task OnGetAsync()
        {
            Gadgets = await _gadgetAPIInvoker.GetGadgets();
            Widgets = await _widgetAPIInvoker.GetWidgets();
        }
    }
}
