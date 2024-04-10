using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetUserForDmmGamesReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsLinkedFieldNumber                      int IL2CPP_TYPE_I4
    // 018 IsLinked                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 020 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Secret                                   000186671910 ModelPrimitiveType string string string String
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 030 SearchId                                 000186671910 ModelPrimitiveType string string string String
    public partial class GetUserForDmmGamesReply : DataModel
    {
        public bool                                     IsLinked                                { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Secret                                  { get; set; }
        public string                                   SearchId                                { get; set; }

        public static GetUserForDmmGamesReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetUserForDmmGamesReply() { Pointer= p0 };

            value.IsLinked                                  = GetBool(new IntPtr(p + 0x018)); // 024660B5C618 0x18 IsLinked                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 024660B5C658 0x20 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x028)); // 024660B5C698 0x28 Secret                      ( 000186671910 ModelPrimitiveType string string string String )
            value.SearchId                                  = GetString(new IntPtr(p + 0x030)); // 024660B5C6D8 0x30 SearchId                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
