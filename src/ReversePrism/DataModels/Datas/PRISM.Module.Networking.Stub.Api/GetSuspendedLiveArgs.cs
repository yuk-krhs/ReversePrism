using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSuspendedLiveArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LiveTokenFieldNumber                     int IL2CPP_TYPE_I4
    // 018 LiveToken                                000186671910 ModelPrimitiveType string string string String
    // 000 DeviceTokenFieldNumber                   int IL2CPP_TYPE_I4
    // 020 DeviceToken                              000186671910 ModelPrimitiveType string string string String
    public partial class GetSuspendedLiveArgs : DataModel
    {
        public string                                   LiveToken                               { get; set; }
        public string                                   DeviceToken                             { get; set; }

        public static GetSuspendedLiveArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSuspendedLiveArgs() { Pointer= p0 };

            value.LiveToken                                 = GetString(new IntPtr(p + 0x018)); // 0246620124B8 0x18 LiveToken                   ( 000186671910 ModelPrimitiveType string string string String )
            value.DeviceToken                               = GetString(new IntPtr(p + 0x020)); // 0246620124F8 0x20 DeviceToken                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
