using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RequestInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RequestIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 RequestId                                000186671910 ModelPrimitiveType string string string String
    // 000 ServingDataFieldNumber                   int IL2CPP_TYPE_I4
    // 020 ServingData                              000186671910 ModelPrimitiveType string string string String
    public partial class RequestInfo
    {
        public string                                   RequestId                               { get; set; }
        public string                                   ServingData                             { get; set; }

        public static RequestInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestInfo();

            value.RequestId                                 = GetString(new IntPtr(p + 0x018)); // 0270DA6F9768 0x18 RequestId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.ServingData                               = GetString(new IntPtr(p + 0x020)); // 0270DA6F97A8 0x20 ServingData                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
