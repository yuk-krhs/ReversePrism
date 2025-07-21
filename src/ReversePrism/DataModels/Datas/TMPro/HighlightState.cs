using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    ModelEnumType Color32 Color32 Color32 Int32
    // 014 Padding                                  ModelEnumType TMP_Offset TMP_Offset TMP_Offset Int32
    public partial class HighlightState : DataModel
    {
        public Color32                                  Color                                   { get; set; }
        public TMP_Offset                               Padding                                 { get; set; }

        public static HighlightState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighlightState() { Pointer= p0 };

            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x010)); // 0x10 Color                       ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Padding                                   = (TMP_Offset)GetInt32(new IntPtr(p + 0x014)); // 0x14 Padding                     ( ModelEnumType TMP_Offset TMP_Offset TMP_Offset Int32 )

            return value;
        }
    }
}
