using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MonoIOError
    {
        ERROR_SUCCESS,
        ERROR_FILE_NOT_FOUND,
        ERROR_PATH_NOT_FOUND,
        ERROR_TOO_MANY_OPEN_FILES,
        ERROR_ACCESS_DENIED,
        ERROR_INVALID_HANDLE,
        ERROR_INVALID_DRIVE,
        ERROR_NOT_SAME_DEVICE,
        ERROR_NO_MORE_FILES,
        ERROR_NOT_READY,
        ERROR_WRITE_FAULT,
        ERROR_READ_FAULT,
        ERROR_GEN_FAILURE,
        ERROR_SHARING_VIOLATION,
        ERROR_LOCK_VIOLATION,
        ERROR_HANDLE_DISK_FULL,
        ERROR_NOT_SUPPORTED,
        ERROR_FILE_EXISTS,
        ERROR_CANNOT_MAKE,
        ERROR_INVALID_PARAMETER,
        ERROR_BROKEN_PIPE,
        ERROR_INVALID_NAME,
        ERROR_DIR_NOT_EMPTY,
        ERROR_ALREADY_EXISTS,
        ERROR_FILENAME_EXCED_RANGE,
        ERROR_DIRECTORY,
        ERROR_ENCRYPTION_FAILED,
    }
}
