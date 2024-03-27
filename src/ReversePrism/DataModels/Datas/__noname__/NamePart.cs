using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<NamePart> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NamePart_FieldNumber                     int IL2CPP_TYPE_I4
    // 008 NamePart_DefaultValue                    string IL2CPP_TYPE_STRING
    // 020 _NamePart                                000186671910 ModelPrimitiveType string string string String
    // 000 IsExtensionFieldNumber                   int IL2CPP_TYPE_I4
    // 010 IsExtensionDefaultValue                  000186596D40 ModelPrimitiveType bool bool bool Bool
    // 028 IsExtension                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NamePart
    {
        public int                                      HasBits0                                { get; set; }
        public string                                   _NamePart                               { get; set; }
        public bool                                     IsExtensionDefaultValue                 { get; set; }
        public bool                                     IsExtension                             { get; set; }

        public static NamePart? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamePart();

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 027003B14458 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._NamePart                                 = GetString(new IntPtr(p + 0x020)); // 027003B144B8 0x20 _NamePart                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IsExtensionDefaultValue                   = GetBool(new IntPtr(p + 0x010)); // 027003B144F8 0x10 IsExtensionDefaultValue     ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.IsExtension                               = GetBool(new IntPtr(p + 0x028)); // 027003B14518 0x28 IsExtension                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
