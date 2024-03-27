using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Status
    {
        Stop,
        Dechead,
        WaitPrep,
        Prep,
        Ready,
        Playing,
        PlayEnd,
        Error,
        StopProcessing,
        ReadyForRendering,
    }
}
