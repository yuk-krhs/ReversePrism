using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProfileArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SearchUserIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 SearchUserId                             000186671910 ModelPrimitiveType string string string String
    public partial class GetProfileArgs : DataModel
    {
        public string                                   SearchUserId                            { get; set; }

        public static GetProfileArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProfileArgs() { Pointer= p0 };

            value.SearchUserId                              = GetString(new IntPtr(p + 0x018)); // 024662CCD8B0 0x18 SearchUserId                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
