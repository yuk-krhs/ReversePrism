using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ChannelOutgestHost                       string IL2CPP_TYPE_STRING
    // 058 ReadedSequenceNumber                     ModelPrimitiveType int int int Int32
    // 060 OutgestServiceClient                     ModelClassType OutgestServiceClient OutgestServiceClient OutgestServiceClient Pointer
    // 068 asyncServerStreamingCall                 AsyncServerStreamingCall`1<Container> IL2CPP_TYPE_GENERICINST
    // 070 dataQueue                                Queue`1<sbyte[]> IL2CPP_TYPE_GENERICINST
    // 078 readedObjectGuids                        HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 080 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 090 SoundView                                ModelClassType SoundView SoundView SoundView Pointer
    // 098 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0A0 IsDisposed                               ModelPrimitiveType bool bool bool Bool
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

            value.ReadedSequenceNumber                      = GetInt32(new IntPtr(p + 0x058)); // 0x58 ReadedSequenceNumber        ( ModelPrimitiveType int int int Int32 )
            value.OutgestServiceClient                      = GetObject<OutgestServiceClient>(new IntPtr(p + 0x060), ReversePrism.DataModels.OutgestServiceClient.FromPointer); // 0x60 OutgestServiceClient        ( ModelClassType OutgestServiceClient OutgestServiceClient OutgestServiceClient Pointer )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x080)); // 0x80 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x090), ReversePrism.DataModels.SoundView.FromPointer); // 0x90 SoundView                   ( ModelClassType SoundView SoundView SoundView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x098), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x98 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
