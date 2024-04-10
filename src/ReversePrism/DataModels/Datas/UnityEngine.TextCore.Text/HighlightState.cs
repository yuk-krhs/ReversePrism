using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 014 Padding                                  0001866D79C0 ModelEnumType Offset Offset Offset Int32
    public partial class HighlightState : DataModel
    {
        public Color32                                  Color                                   { get; set; }
        public Offset                                   Padding                                 { get; set; }

        public static HighlightState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighlightState() { Pointer= p0 };

            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x010)); // 0245A68ADFB0 0x10 Color                       ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Padding                                   = (Offset)GetInt32(new IntPtr(p + 0x014)); // 0245A68ADFD0 0x14 Padding                     ( 0001866D79C0 ModelEnumType Offset Offset Offset Int32 )

            return value;
        }
    }
}
