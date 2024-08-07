using Microsoft.AspNetCore.Mvc;

namespace GadgetWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetController : ControllerBase
    {
        private readonly ILogger<GadgetController> _logger;

        public GadgetController(ILogger<GadgetController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGadgets")]
        public IEnumerable<Gadget> Get()
        {
            return new List<Gadget>()
            {
                new Gadget()
                {
                    GadgetKey = "A",
                    GadgetType = "Type A",
                    UsageInstructions = "Use Gadget A to assemble Widgets."
                },
                new Gadget()
                {
                    GadgetKey = "B",
                    GadgetType = "Type B",
                    UsageInstructions = "Use Gadget B to test Widgets."
                },
                new Gadget()
                {
                    GadgetKey = "C",
                    GadgetType = "Type C",
                    UsageInstructions = "Use Gadget C to use Widgets."
                }
            }.ToArray();
        }
    }
}
