using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NativeDumpFlags
    {
        None,
        IL,
        Unused,
        IR,
        IROptimized,
        Asm,
        Function,
        Analysis,
        IRPassAnalysis,
        ILPre,
        IRPerEntryPoint,
        All,
    }
}
