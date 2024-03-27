using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum StatusCode
    {
        OK,
        Cancelled,
        Unknown,
        InvalidArgument,
        DeadlineExceeded,
        NotFound,
        AlreadyExists,
        PermissionDenied,
        Unauthenticated,
        ResourceExhausted,
        FailedPrecondition,
        Aborted,
        OutOfRange,
        Unimplemented,
        Internal,
        Unavailable,
        DataLoss,
    }
}
