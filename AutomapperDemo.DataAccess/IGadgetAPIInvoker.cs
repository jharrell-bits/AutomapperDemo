using AutomapperDemo.Models;

namespace AutomapperDemo.DataAccess
{
    public interface IGadgetAPIInvoker
    {
        Task<List<Gadget>> GetGadgets();
    }
}
