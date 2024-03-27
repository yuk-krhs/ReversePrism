using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReleasableDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetConnectURLReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ConnectedFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Connected                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UrlFieldNumber                           int IL2CPP_TYPE_I4
    // 030 Url                                      000186671910 ModelPrimitiveType string string string String
    // 000 ReleasableDateFieldNumber                int IL2CPP_TYPE_I4
    // 038 _ReleasableDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetConnectURLReply
    {
        public DateTime                                 ReleasableDate                          { get; set; }
        public bool                                     Connected                               { get; set; }
        public string                                   Url                                     { get; set; }
        public Timestamp?                               _ReleasableDate                         { get; set; }

        public static GetConnectURLReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetConnectURLReply();

            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0270D2C42320 0x10 ReleasableDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Connected                                 = GetBool(new IntPtr(p + 0x028)); // 0270D2C423A0 0x28 Connected                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Url                                       = GetString(new IntPtr(p + 0x030)); // 0270D2C423E0 0x30 Url                         ( 000186671910 ModelPrimitiveType string string string String )
            value._ReleasableDate                           = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2C42420 0x38 _ReleasableDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ReleasableDate                = ToDateTime(value._ReleasableDate);

            return value;
        }
    }
}
