using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Response> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CodeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Code                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 000 SizeFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Size                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 000 HeadersFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _map_headers_codec                       Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 028 headers_                                 MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 TimeFieldNumber                          int IL2CPP_TYPE_I4
    // 030 _Time                                    000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 BackendLatencyFieldNumber                int IL2CPP_TYPE_I4
    // 038 BackendLatency                           00018670DB80 ModelClassType Duration Duration Duration Pointer
    public partial class Response : DataModel
    {
        public long                                     Code                                    { get; set; }
        public long                                     Size                                    { get; set; }
        public Timestamp?                               _Time                                   { get; set; }
        public Duration?                                BackendLatency                          { get; set; }

        public static Response? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Response() { Pointer= p0 };

            value.Code                                      = GetInt64(new IntPtr(p + 0x018)); // 02466A7729C0 0x18 Code                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Size                                      = GetInt64(new IntPtr(p + 0x020)); // 02466A772A00 0x20 Size                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value._Time                                     = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A772AA0 0x30 _Time                       ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BackendLatency                            = GetObject<Duration>(new IntPtr(p + 0x038), ReversePrism.DataModels.Duration.FromPointer); // 02466A772AE0 0x38 BackendLatency              ( 00018670DB80 ModelClassType Duration Duration Duration Pointer )

            return value;
        }
    }
}
