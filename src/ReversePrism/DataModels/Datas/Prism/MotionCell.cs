using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Label                                    0001866722E0 ModelPrimitiveType string string string String
    // 018 Mid                                      0001866722E0 ModelPrimitiveType string string string String
    // 020 Len                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Col                                      0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class MotionCell : DataModel
    {
        public string                                   Label                                   { get; set; }
        public string                                   Mid                                     { get; set; }
        public int                                      Len                                     { get; set; }
        public Color                                    Col                                     { get; set; }

        public static MotionCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MotionCell() { Pointer= p0 };

            value.Label                                     = GetString(new IntPtr(p + 0x010)); // 024664EC1248 0x10 Label                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Mid                                       = GetString(new IntPtr(p + 0x018)); // 024664EC1268 0x18 Mid                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Len                                       = GetInt32(new IntPtr(p + 0x020)); // 024664EC1288 0x20 Len                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Col                                       = (Color)GetInt32(new IntPtr(p + 0x024)); // 024664EC12A8 0x24 Col                         ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
