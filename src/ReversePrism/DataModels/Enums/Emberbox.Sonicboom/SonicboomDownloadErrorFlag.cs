using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SonicboomDownloadErrorFlag
    {
        DownloadErrorNone,
        DownloadErrorFileOpen,
        DownloadErrorFileWrite,
        DownloadErrorFileFlush,
        DownloadErrorFileClose,
        DownloadErrorFileStat,
        DownloadErrorFileSizeMismatch,
        DownloadErrorFileLocalCache,
        DownloadErrorChecksumCalc,
        DownloadErrorChecksumMismatch,
        DownloadErrorDownloadedSizeMismatch,
        DownloadErrorCurlmAddHandle,
        DownloadErrorCurl,
        DownloadErrorHttpStatus,
        DownloadErrorIntegrityFileOverlap,
        DownloadErrorConnectionTimeout,
        DownloadErrorUserCancel,
        DownloadErrorFatal,
    }
}
