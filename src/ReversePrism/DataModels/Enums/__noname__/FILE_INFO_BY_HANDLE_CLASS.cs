using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FILE_INFO_BY_HANDLE_CLASS
    {
        FileBasicInfo,
        FileStandardInfo,
        FileNameInfo,
        FileRenameInfo,
        FileDispositionInfo,
        FileAllocationInfo,
        FileEndOfFileInfo,
        FileStreamInfo,
        FileCompressionInfo,
        FileAttributeTagInfo,
        FileIdBothDirectoryInfo,
        FileIdBothDirectoryRestartInfo,
        FileIoPriorityHintInfo,
        FileRemoteProtocolInfo,
        FileFullDirectoryInfo,
        FileFullDirectoryRestartInfo,
    }
}
