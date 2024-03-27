using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExtensionRange> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StartFieldNumber                         int IL2CPP_TYPE_I4
    // 008 StartDefaultValue                        int IL2CPP_TYPE_I4
    // 01C Start                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EndFieldNumber                           int IL2CPP_TYPE_I4
    // 00C EndDefaultValue                          int IL2CPP_TYPE_I4
    // 020 End                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Options                                  000186532560 ModelClassType ExtensionRangeOptions ExtensionRangeOptions ExtensionRangeOptions Pointer
    public partial class ExtensionRange
    {
        public int                                      HasBits0                                { get; set; }
        public int                                      Start                                   { get; set; }
        public int                                      End                                     { get; set; }
        public ExtensionRangeOptions?                   Options                                 { get; set; }

        public static ExtensionRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionRange();

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D0B92A60 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Start                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D0B92AC0 0x1C Start                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x020)); // 0270D0B92B20 0x20 End                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Options                                   = GetObject<ExtensionRangeOptions>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExtensionRangeOptions.FromPointer); // 0270D0B92B60 0x28 Options                     ( 000186532560 ModelClassType ExtensionRangeOptions ExtensionRangeOptions ExtensionRangeOptions Pointer )

            return value;
        }
    }
}
