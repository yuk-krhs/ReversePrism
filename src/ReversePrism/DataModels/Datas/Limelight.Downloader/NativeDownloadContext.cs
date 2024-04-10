using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Downloader                               000186685A40 ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer
    // 018 UniqueIds                                000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 Queue                                    0001865BD700 ModelClassType INativeDownloadQueue INativeDownloadQueue INativeDownloadQueue Pointer
    // 028 Throughput                               00018665EDB0 ModelClassType ThroughputMonitor ThroughputMonitor ThroughputMonitor Pointer
    // 030 TimeoutTimer                             00018658EAD0 ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    // 038 overlapMap                               Dictionary`2<int, List`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 MaxRequestIdx                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 LivingRequestNum                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 IdPeak                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 LastElapsedTransferBytes                 0001865F7700 ModelPrimitiveType long long long Int64
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

            value.Downloader                                = GetObject<NativeDownloadApi>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeDownloadApi.FromPointer); // 02466B5751A0 0x10 Downloader                  ( 000186685A40 ModelClassType NativeDownloadApi NativeDownloadApi NativeDownloadApi Pointer )
            value.UniqueIds                                 = GetInt32List(new IntPtr(p + 0x018)); // 02466B5751C0 0x18 UniqueIds                   ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Queue                                     = GetObject<INativeDownloadQueue>(new IntPtr(p + 0x020), ReversePrism.DataModels.INativeDownloadQueue.FromPointer); // 02466B5751E0 0x20 Queue                       ( 0001865BD700 ModelClassType INativeDownloadQueue INativeDownloadQueue INativeDownloadQueue Pointer )
            value.Throughput                                = GetObject<ThroughputMonitor>(new IntPtr(p + 0x028), ReversePrism.DataModels.ThroughputMonitor.FromPointer); // 02466B575200 0x28 Throughput                  ( 00018665EDB0 ModelClassType ThroughputMonitor ThroughputMonitor ThroughputMonitor Pointer )
            value.TimeoutTimer                              = GetObject<Stopwatch>(new IntPtr(p + 0x030), ReversePrism.DataModels.Stopwatch.FromPointer); // 02466B575220 0x30 TimeoutTimer                ( 00018658EAD0 ModelClassType Stopwatch Stopwatch Stopwatch Pointer )
            value.MaxRequestIdx                             = GetInt32(new IntPtr(p + 0x040)); // 02466B575260 0x40 MaxRequestIdx               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LivingRequestNum                          = GetInt32(new IntPtr(p + 0x044)); // 02466B575280 0x44 LivingRequestNum            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdPeak                                    = GetInt32(new IntPtr(p + 0x048)); // 02466B5752A0 0x48 IdPeak                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastElapsedTransferBytes                  = GetInt64(new IntPtr(p + 0x050)); // 02466B5752C0 0x50 LastElapsedTransferBytes    ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
