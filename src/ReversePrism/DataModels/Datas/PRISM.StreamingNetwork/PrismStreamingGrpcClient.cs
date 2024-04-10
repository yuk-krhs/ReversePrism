using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ChannelOutgestHost                       string IL2CPP_TYPE_STRING
    // 058 ReadedSequenceNumber                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 OutgestServiceClient                     000186546A70 ModelClassType OutgestServiceClient OutgestServiceClient OutgestServiceClient Pointer
    // 068 asyncServerStreamingCall                 AsyncServerStreamingCall`1<Container> IL2CPP_TYPE_GENERICINST
    // 070 dataQueue                                Queue`1<sbyte[]> IL2CPP_TYPE_GENERICINST
    // 078 readedObjectGuids                        HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 080 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 090 SoundView                                000186538FC0 ModelClassType SoundView SoundView SoundView Pointer
    // 098 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0A0 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PrismStreamingGrpcClient : DataModel
    {
        public int                                      ReadedSequenceNumber                    { get; set; }
        public OutgestServiceClient?                    OutgestServiceClient                    { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public SoundView?                               SoundView                               { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     IsDisposed                              { get; set; }

        public static PrismStreamingGrpcClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreamingGrpcClient() { Pointer= p0 };

            value.ReadedSequenceNumber                      = GetInt32(new IntPtr(p + 0x058)); // 024664F8EEE0 0x58 ReadedSequenceNumber        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OutgestServiceClient                      = GetObject<OutgestServiceClient>(new IntPtr(p + 0x060), ReversePrism.DataModels.OutgestServiceClient.FromPointer); // 024664F8EF00 0x60 OutgestServiceClient        ( 000186546A70 ModelClassType OutgestServiceClient OutgestServiceClient OutgestServiceClient Pointer )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x080)); // 024664F8EF80 0x80 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x090), ReversePrism.DataModels.SoundView.FromPointer); // 024664F8EFA0 0x90 SoundView                   ( 000186538FC0 ModelClassType SoundView SoundView SoundView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x098), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024664F8EFC0 0x98 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x0A0)); // 024664F8EFE0 0xA0 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
