using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SonicboomConfigKey
    {
        SonicboomConfigEntryMaxDownloaders,
        SonicboomConfigEntryDefaultNumDownloaders,
        SonicboomConfigEntryNumWriters,
        SonicboomConfigEntryMaxStreams,
        SonicboomConfigEntryDisableErrorBuffer,
        SonicboomConfigEntryDisableSslVerifyhost,
        SonicboomConfigEntryConnectTimeoutMs,
        SonicboomConfigEntryDownloadBufferBytes,
        SonicboomConfigEntryThreadIdleSleepMs,
        SonicboomConfigEntryMaxTotalConnections,
        SonicboomConfigEntryMaxDownloadBufferChunks,
    }
}
