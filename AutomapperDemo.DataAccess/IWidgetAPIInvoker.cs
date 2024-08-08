using AutomapperDemo.Models;

namespace AutomapperDemo.DataAccess
{
    public interface IWidgetAPIInvoker
    {
        Task<List<Widget>> GetWidgets();
    }
}
