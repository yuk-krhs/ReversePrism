using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FtpOperation
    {
        DownloadFile,
        ListDirectory,
        ListDirectoryDetails,
        UploadFile,
        UploadFileUnique,
        AppendFile,
        DeleteFile,
        GetDateTimestamp,
        GetFileSize,
        Rename,
        MakeDirectory,
        RemoveDirectory,
        PrintWorkingDirectory,
        Other,
    }
}
