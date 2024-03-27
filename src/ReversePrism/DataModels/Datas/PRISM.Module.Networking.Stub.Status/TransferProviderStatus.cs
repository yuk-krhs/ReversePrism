using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReleasableDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<TransferProviderStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 ProviderType                             0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 ConnectedFieldNumber                     int IL2CPP_TYPE_I4
    // 02C Connected                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ReleasableDateFieldNumber                int IL2CPP_TYPE_I4
    // 030 _ReleasableDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class TransferProviderStatus
    {
        public DateTime                                 ReleasableDate                          { get; set; }
        public TransferProviderType                     ProviderType                            { get; set; }
        public bool                                     Connected                               { get; set; }
        public Timestamp?                               _ReleasableDate                         { get; set; }

        public static TransferProviderStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferProviderStatus();

            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0270D0F4AC28 0x10 ReleasableDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x028)); // 0270D0F4ACA8 0x28 ProviderType                ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Connected                                 = GetBool(new IntPtr(p + 0x02C)); // 0270D0F4ACE8 0x2C Connected                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._ReleasableDate                           = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F4AD28 0x30 _ReleasableDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ReleasableDate                = ToDateTime(value._ReleasableDate);

            return value;
        }
    }
}
