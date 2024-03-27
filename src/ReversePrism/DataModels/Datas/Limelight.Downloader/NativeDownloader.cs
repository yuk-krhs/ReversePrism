using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Worker                                   000186686DE0 ModelClassType NativeDownloadWorker NativeDownloadWorker NativeDownloadWorker Pointer
    // 018 Channel                                  0001866EFB30 ModelClassType DownloadCommandChannel DownloadCommandChannel DownloadCommandChannel Pointer
    // 020 CSource                                  0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 SharedCommand                            0001867523A0 ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer
    // 000 MaxFrameIntervalForReachability          int IL2CPP_TYPE_I4
    // 030 FrameIntervalForReachability             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 savedReachability                        Nullable`1<NetworkReachability> IL2CPP_TYPE_GENERICINST
    // 040 TotalDownloadBytes                       0001865F7700 ModelPrimitiveType long long long Int64
    // 048 DownloadedBytes                          0001865F7700 ModelPrimitiveType long long long Int64
    public partial class NativeDownloader
    {
        public NativeDownloadWorker?                    Worker                                  { get; set; }
        public DownloadCommandChannel?                  Channel                                 { get; set; }
        public CancellationTokenSource?                 CSource                                 { get; set; }
        public SharedDownloadStateCommand?              SharedCommand                           { get; set; }
        public int                                      FrameIntervalForReachability            { get; set; }
        public long                                     TotalDownloadBytes                      { get; set; }
        public long                                     DownloadedBytes                         { get; set; }

        public static NativeDownloader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloader();

            value.Worker                                    = GetObject<NativeDownloadWorker>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeDownloadWorker.FromPointer); // 027003E1F010 0x10 Worker                      ( 000186686DE0 ModelClassType NativeDownloadWorker NativeDownloadWorker NativeDownloadWorker Pointer )
            value.Channel                                   = GetObject<DownloadCommandChannel>(new IntPtr(p + 0x018), ReversePrism.DataModels.DownloadCommandChannel.FromPointer); // 027003E1F030 0x18 Channel                     ( 0001866EFB30 ModelClassType DownloadCommandChannel DownloadCommandChannel DownloadCommandChannel Pointer )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027003E1F050 0x20 CSource                     ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SharedCommand                             = GetObject<SharedDownloadStateCommand>(new IntPtr(p + 0x028), ReversePrism.DataModels.SharedDownloadStateCommand.FromPointer); // 027003E1F070 0x28 SharedCommand               ( 0001867523A0 ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer )
            value.FrameIntervalForReachability              = GetInt32(new IntPtr(p + 0x030)); // 027003E1F0B0 0x30 FrameIntervalForReachability ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x040)); // 027003E1F0F0 0x40 TotalDownloadBytes          ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DownloadedBytes                           = GetInt64(new IntPtr(p + 0x048)); // 027003E1F110 0x48 DownloadedBytes             ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
