using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum unitytls_error_code
    {
        UNITYTLS_SUCCESS,
        UNITYTLS_INVALID_ARGUMENT,
        UNITYTLS_INVALID_FORMAT,
        UNITYTLS_INVALID_PASSWORD,
        UNITYTLS_INVALID_STATE,
        UNITYTLS_BUFFER_OVERFLOW,
        UNITYTLS_OUT_OF_MEMORY,
        UNITYTLS_INTERNAL_ERROR,
        UNITYTLS_NOT_SUPPORTED,
        UNITYTLS_ENTROPY_SOURCE_FAILED,
        UNITYTLS_STREAM_CLOSED,
        UNITYTLS_USER_CUSTOM_ERROR_START,
        UNITYTLS_USER_WOULD_BLOCK,
        UNITYTLS_USER_READ_FAILED,
        UNITYTLS_USER_WRITE_FAILED,
        UNITYTLS_USER_UNKNOWN_ERROR,
        UNITYTLS_USER_CUSTOM_ERROR_END,
    }
}
