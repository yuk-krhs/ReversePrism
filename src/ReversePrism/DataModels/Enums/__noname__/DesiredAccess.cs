using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DesiredAccess
    {
        FILE_READ_DATA,
        FILE_LIST_DIRECTORY,
        FILE_WRITE_DATA,
        FILE_ADD_FILE,
        FILE_APPEND_DATA,
        FILE_ADD_SUBDIRECTORY,
        FILE_CREATE_PIPE_INSTANCE,
        FILE_READ_EA,
        FILE_WRITE_EA,
        FILE_EXECUTE,
        FILE_TRAVERSE,
        FILE_DELETE_CHILD,
        FILE_READ_ATTRIBUTES,
        FILE_WRITE_ATTRIBUTES,
        FILE_ALL_ACCESS,
        DELETE,
        READ_CONTROL,
        WRITE_DAC,
        WRITE_OWNER,
        SYNCHRONIZE,
        STANDARD_RIGHTS_READ,
        STANDARD_RIGHTS_WRITE,
        STANDARD_RIGHTS_EXECUTE,
        FILE_GENERIC_READ,
        FILE_GENERIC_WRITE,
        FILE_GENERIC_EXECUTE,
    }
}
