using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Tooltip                                  ModelPrimitiveType string string string String
    // 090 Rect                                     ModelEnumType Rect Rect Rect Int32
    public partial class TooltipEvent : DataModel
    {
        public string                                   Tooltip                                 { get; set; }
        public Rect                                     Rect                                    { get; set; }

        public static TooltipEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TooltipEvent() { Pointer= p0 };

            value.Tooltip                                   = GetString(new IntPtr(p + 0x088)); // 0x88 Tooltip                     ( ModelPrimitiveType string string string String )
            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x090)); // 0x90 Rect                        ( ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
