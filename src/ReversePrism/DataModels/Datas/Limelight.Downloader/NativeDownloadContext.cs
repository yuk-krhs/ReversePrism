using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Downloader                               ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer
    // 018 UniqueIds                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 Queue                                    ModelClassType INativeDownloadQueue INativeDownloadQueue INativeDownloadQueue Pointer
    // 028 Throughput                               ModelClassType ThroughputMonitor ThroughputMonitor ThroughputMonitor Pointer
    // 030 TimeoutTimer                             ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    // 038 overlapMap                               Dictionary`2<int, List`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 MaxRequestIdx                            ModelPrimitiveType int int int Int32
    // 044 LivingRequestNum                         ModelPrimitiveType int int int Int32
    // 048 IdPeak                                   ModelPrimitiveType int int int Int32
    // 050 LastElapsedTransferBytes                 ModelPrimitiveType long long long Int64
    // 000 THROUGHPUT_RESET_TIMEOUT_MSEC            int IL2CPP_TYPE_I4
    public partial class NativeDownloadContext : DataModel
    {
        public NativeDownloadApi?                       Downloader                              { get; set; }
        public List<int>?                               UniqueIds                               { get; set; }
        public INativeDownloadQueue?                    Queue                                   { get; set; }
        public ThroughputMonitor?                       Throughput                              { get; set; }
        public Stopwatch?                               TimeoutTimer                            { get; set; }
        public int                                      MaxRequestIdx                           { get; set; }
        public int                                      LivingRequestNum                        { get; set; }
        public int                                      IdPeak                                  { get; set; }
        public long                                     LastElapsedTransferBytes                { get; set; }

        public static NativeDownloadContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadContext() { Pointer= p0 };

            value.Downloader                                = GetObject<NativeDownloadApi>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeDownloadApi.FromPointer); // 0x10 Downloader                  ( ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer )
            value.UniqueIds                                 = GetInt32List(new IntPtr(p + 0x018)); // 0x18 UniqueIds                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Queue                                     = GetObject<INativeDownloadQueue>(new IntPtr(p + 0x020), ReversePrism.DataModels.INativeDownloadQueue.FromPointer); // 0x20 Queue                       ( ModelClassType INativeDownloadQueue INativeDownloadQueue INativeDownloadQueue Pointer )
            value.Throughput                                = GetObject<ThroughputMonitor>(new IntPtr(p + 0x028), ReversePrism.DataModels.ThroughputMonitor.FromPointer); // 0x28 Throughput                  ( ModelClassType ThroughputMonitor ThroughputMonitor ThroughputMonitor Pointer )
            value.TimeoutTimer                              = GetObject<Stopwatch>(new IntPtr(p + 0x030), ReversePrism.DataModels.Stopwatch.FromPointer); // 0x30 TimeoutTimer                ( ModelClassType Stopwatch Stopwatch Stopwatch Pointer )
            value.MaxRequestIdx                             = GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxRequestIdx               ( ModelPrimitiveType int int int Int32 )
            value.LivingRequestNum                          = GetInt32(new IntPtr(p + 0x044)); // 0x44 LivingRequestNum            ( ModelPrimitiveType int int int Int32 )
            value.IdPeak                                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 IdPeak                      ( ModelPrimitiveType int int int Int32 )
            value.LastElapsedTransferBytes                  = GetInt64(new IntPtr(p + 0x050)); // 0x50 LastElapsedTransferBytes    ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
