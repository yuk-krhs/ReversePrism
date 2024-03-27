using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Endpoint> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 AliasesFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_aliases_codec                  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 Aliases                                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 TargetFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Target                                   000186671910 ModelPrimitiveType string string string String
    // 000 AllowCorsFieldNumber                     int IL2CPP_TYPE_I4
    // 030 AllowCors                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Endpoint
    {
        public string                                   Name                                    { get; set; }
        public List<string>?                            Aliases                                 { get; set; }
        public string                                   Target                                  { get; set; }
        public bool                                     AllowCors                               { get; set; }

        public static Endpoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Endpoint();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DA7C99F8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x020)); // 0270DA7C9A58 0x20 Aliases                     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Target                                    = GetString(new IntPtr(p + 0x028)); // 0270DA7C9A98 0x28 Target                      ( 000186671910 ModelPrimitiveType string string string String )
            value.AllowCors                                 = GetBool(new IntPtr(p + 0x030)); // 0270DA7C9AD8 0x30 AllowCors                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
