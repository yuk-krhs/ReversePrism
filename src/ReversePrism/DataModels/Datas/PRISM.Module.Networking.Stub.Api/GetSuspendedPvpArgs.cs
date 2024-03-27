using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSuspendedPvpArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DeviceTokenFieldNumber                   int IL2CPP_TYPE_I4
    // 018 DeviceToken                              000186671910 ModelPrimitiveType string string string String
    public partial class GetSuspendedPvpArgs
    {
        public string                                   DeviceToken                             { get; set; }

        public static GetSuspendedPvpArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSuspendedPvpArgs();

            value.DeviceToken                               = GetString(new IntPtr(p + 0x018)); // 0270D20556C8 0x18 DeviceToken                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
