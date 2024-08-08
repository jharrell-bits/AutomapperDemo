using AutomapperDemoModels;

namespace AutomapperDemoDataAccess
{
    public interface IWidgetAPIInvoker
    {
        Task<List<Widget>> GetWidgets();
    }
}
