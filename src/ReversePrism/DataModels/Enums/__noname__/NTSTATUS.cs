using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NTSTATUS
    {
        STATUS_SUCCESS,
        STATUS_NOT_FOUND,
        STATUS_INVALID_PARAMETER,
        STATUS_NO_MEMORY,
    }
}
