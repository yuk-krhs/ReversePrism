using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Worker                                   ModelClassType NativeDownloadWorker NativeDownloadWorker NativeDownloadWorker Pointer
    // 018 Channel                                  ModelClassType DownloadCommandChannel DownloadCommandChannel DownloadCommandChannel Pointer
    // 020 CSource                                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 SharedCommand                            ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer
    // 000 MaxFrameIntervalForReachability          int IL2CPP_TYPE_I4
    // 030 FrameIntervalForReachability             ModelPrimitiveType int int int Int32
    // 034 savedReachability                        Nullable`1<NetworkReachability> IL2CPP_TYPE_GENERICINST
    // 040 TotalDownloadBytes                       ModelPrimitiveType long long long Int64
    // 048 DownloadedBytes                          ModelPrimitiveType long long long Int64
    public partial class NativeDownloader : DataModel
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
            var value   = new NativeDownloader() { Pointer= p0 };

            value.Worker                                    = GetObject<NativeDownloadWorker>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeDownloadWorker.FromPointer); // 0x10 Worker                      ( ModelClassType NativeDownloadWorker NativeDownloadWorker NativeDownloadWorker Pointer )
            value.Channel                                   = GetObject<DownloadCommandChannel>(new IntPtr(p + 0x018), ReversePrism.DataModels.DownloadCommandChannel.FromPointer); // 0x18 Channel                     ( ModelClassType DownloadCommandChannel DownloadCommandChannel DownloadCommandChannel Pointer )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 CSource                     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SharedCommand                             = GetObject<SharedDownloadStateCommand>(new IntPtr(p + 0x028), ReversePrism.DataModels.SharedDownloadStateCommand.FromPointer); // 0x28 SharedCommand               ( ModelClassType SharedDownloadStateCommand SharedDownloadStateCommand SharedDownloadStateCommand Pointer )
            value.FrameIntervalForReachability              = GetInt32(new IntPtr(p + 0x030)); // 0x30 FrameIntervalForReachability ( ModelPrimitiveType int int int Int32 )
            value.TotalDownloadBytes                        = GetInt64(new IntPtr(p + 0x040)); // 0x40 TotalDownloadBytes          ( ModelPrimitiveType long long long Int64 )
            value.DownloadedBytes                           = GetInt64(new IntPtr(p + 0x048)); // 0x48 DownloadedBytes             ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
