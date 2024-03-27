using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SearchUserArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SearchUserIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 SearchUserId                             000186671910 ModelPrimitiveType string string string String
    public partial class SearchUserArgs
    {
        public string                                   SearchUserId                            { get; set; }

        public static SearchUserArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SearchUserArgs();

            value.SearchUserId                              = GetString(new IntPtr(p + 0x018)); // 0270D2D1FD58 0x18 SearchUserId                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
