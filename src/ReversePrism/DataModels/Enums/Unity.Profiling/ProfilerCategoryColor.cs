using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProfilerCategoryColor
    {
        Render,
        Scripts,
        BurstJobs,
        Other,
        Physics,
        Animation,
        Audio,
        AudioJob,
        AudioUpdateJob,
        Lighting,
        GC,
        VSync,
        Memory,
        Internal,
        UI,
        Build,
        Input,
    }
}
