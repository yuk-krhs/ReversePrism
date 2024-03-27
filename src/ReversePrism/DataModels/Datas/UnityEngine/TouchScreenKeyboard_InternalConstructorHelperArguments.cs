using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeyboardType                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Autocorrection                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Multiline                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C Secure                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 Alert                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 CharacterLimit                           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TouchScreenKeyboard_InternalConstructorHelperArguments
    {
        public uint                                     KeyboardType                            { get; set; }
        public uint                                     Autocorrection                          { get; set; }
        public uint                                     Multiline                               { get; set; }
        public uint                                     Secure                                  { get; set; }
        public uint                                     Alert                                   { get; set; }
        public int                                      CharacterLimit                          { get; set; }

        public static TouchScreenKeyboard_InternalConstructorHelperArguments? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchScreenKeyboard_InternalConstructorHelperArguments();

            value.KeyboardType                              = GetUInt32(new IntPtr(p + 0x010)); // 0270068BE110 0x10 KeyboardType                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Autocorrection                            = GetUInt32(new IntPtr(p + 0x014)); // 0270068BE130 0x14 Autocorrection              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Multiline                                 = GetUInt32(new IntPtr(p + 0x018)); // 0270068BE150 0x18 Multiline                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Secure                                    = GetUInt32(new IntPtr(p + 0x01C)); // 0270068BE170 0x1C Secure                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Alert                                     = GetUInt32(new IntPtr(p + 0x020)); // 0270068BE190 0x20 Alert                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CharacterLimit                            = GetInt32(new IntPtr(p + 0x024)); // 0270068BE1B0 0x24 CharacterLimit              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
