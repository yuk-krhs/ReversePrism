using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 Tooltip                                  000186671910 ModelPrimitiveType string string string String
    // 090 Rect                                     00018664F620 ModelEnumType Rect Rect Rect Int32
    public partial class TooltipEvent
    {
        public string                                   Tooltip                                 { get; set; }
        public Rect                                     Rect                                    { get; set; }

        public static TooltipEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TooltipEvent();

            value.Tooltip                                   = GetString(new IntPtr(p + 0x088)); // 0270067D11B0 0x88 Tooltip                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x090)); // 0270067D11D0 0x90 Rect                        ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
