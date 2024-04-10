using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetDmmGamesAPITokenReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Token                                    000186671910 ModelPrimitiveType string string string String
    public partial class GetDmmGamesAPITokenReply : DataModel
    {
        public string                                   Token                                   { get; set; }

        public static GetDmmGamesAPITokenReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetDmmGamesAPITokenReply() { Pointer= p0 };

            value.Token                                     = GetString(new IntPtr(p + 0x018)); // 0246618E24A0 0x18 Token                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
