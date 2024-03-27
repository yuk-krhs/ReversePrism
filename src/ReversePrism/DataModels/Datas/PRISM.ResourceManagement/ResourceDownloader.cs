using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Core                                     00018652BD10 ModelClassType LimelightCore LimelightCore LimelightCore Pointer
    // 018 progressForCategory                      Dictionary`2<DownloadCategory, long> IL2CPP_TYPE_GENERICINST
    // 020 totalForCategory                         Dictionary`2<DownloadCategory, long> IL2CPP_TYPE_GENERICINST
    // 028 runningDownloads                         Dictionary`2<DownloadCategory, HashSet`1<IDownloadJobProvider>> IL2CPP_TYPE_GENERICINST
    // 030 handlers                                 HashSet`1<IDownloadEventHandler> IL2CPP_TYPE_GENERICINST
    public partial class ResourceDownloader
    {
        public LimelightCore?                           Core                                    { get; set; }

        public static ResourceDownloader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceDownloader();

            value.Core                                      = GetObject<LimelightCore>(new IntPtr(p + 0x010), ReversePrism.DataModels.LimelightCore.FromPointer); // 027003CF5480 0x10 Core                        ( 00018652BD10 ModelClassType LimelightCore LimelightCore LimelightCore Pointer )

            return value;
        }
    }
}
