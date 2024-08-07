using AutomapperDemoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperDemoDataAccess
{
    public interface IGadgetAPIInvoker
    {
        Task<List<Gadget>> GetGadgets();
    }
}
