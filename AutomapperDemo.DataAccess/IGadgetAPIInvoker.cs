using AutomapperDemoModels;

namespace AutomapperDemoDataAccess
{
    public interface IGadgetAPIInvoker
    {
        Task<List<Gadget>> GetGadgets();
    }
}
