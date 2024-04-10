using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameHashCode                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ValueHashCode                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ValueType                                00018661BDC0 ModelEnumType TagValueType TagValueType TagValueType Int32
    // 01C ValueStartIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 ValueLength                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 UnitType                                 00018661AFB0 ModelEnumType TagUnitType TagUnitType TagUnitType Int32
    public partial class RichTextTagAttribute : DataModel
    {
        public int                                      NameHashCode                            { get; set; }
        public int                                      ValueHashCode                           { get; set; }
        public TagValueType                             ValueType                               { get; set; }
        public int                                      ValueStartIndex                         { get; set; }
        public int                                      ValueLength                             { get; set; }
        public TagUnitType                              UnitType                                { get; set; }

        public static RichTextTagAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RichTextTagAttribute() { Pointer= p0 };

            value.NameHashCode                              = GetInt32(new IntPtr(p + 0x010)); // 0245A68BC218 0x10 NameHashCode                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ValueHashCode                             = GetInt32(new IntPtr(p + 0x014)); // 0245A68BC238 0x14 ValueHashCode               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ValueType                                 = (TagValueType)GetInt32(new IntPtr(p + 0x018)); // 0245A68BC258 0x18 ValueType                   ( 00018661BDC0 ModelEnumType TagValueType TagValueType TagValueType Int32 )
            value.ValueStartIndex                           = GetInt32(new IntPtr(p + 0x01C)); // 0245A68BC278 0x1C ValueStartIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ValueLength                               = GetInt32(new IntPtr(p + 0x020)); // 0245A68BC298 0x20 ValueLength                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UnitType                                  = (TagUnitType)GetInt32(new IntPtr(p + 0x024)); // 0245A68BC2B8 0x24 UnitType                    ( 00018661AFB0 ModelEnumType TagUnitType TagUnitType TagUnitType Int32 )

            return value;
        }
    }
}
