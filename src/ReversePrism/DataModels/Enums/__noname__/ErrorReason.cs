using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ErrorReason
    {
        Undefined,
        HttpConnectionError,
        DataProcessingError,
        ProtocolError,
        DiskWriteError,
        DiskFullPredictedError,
        GeneralIOError,
        NativePluginError,
        InternalFileOverlap,
        ChecksumError,
        CurlError,
        ApplicationTimeout,
        Fatal,
    }
}
