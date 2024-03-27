using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RemoveFollowArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UserId                                   000186671910 ModelPrimitiveType string string string String
    public partial class RemoveFollowArgs
    {
        public string                                   UserId                                  { get; set; }

        public static RemoveFollowArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoveFollowArgs();

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0270D14195C8 0x18 UserId                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
