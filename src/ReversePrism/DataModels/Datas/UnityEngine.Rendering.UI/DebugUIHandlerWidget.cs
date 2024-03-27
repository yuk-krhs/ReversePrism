using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ColorDefault                             0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 ColorSelected                            0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 ParentUIHandler                          0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 048 PreviousUIHandler                        0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 050 NextUIHandler                            0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 058 M_Widget                                 00018658BD60 ModelClassType Widget Widget Widget Pointer
    public partial class DebugUIHandlerWidget
    {
        public Color                                    ColorDefault                            { get; set; }
        public Color                                    ColorSelected                           { get; set; }
        public DebugUIHandlerWidget?                    ParentUIHandler                         { get; set; }
        public DebugUIHandlerWidget?                    PreviousUIHandler                       { get; set; }
        public DebugUIHandlerWidget?                    NextUIHandler                           { get; set; }
        public Widget?                                  M_Widget                                { get; set; }

        public static DebugUIHandlerWidget? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerWidget();

            value.ColorDefault                              = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270026B67B8 0x20 ColorDefault                ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.ColorSelected                             = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270026B67D8 0x30 ColorSelected               ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.ParentUIHandler                           = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x040), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0270026B67F8 0x40 ParentUIHandler             ( 0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.PreviousUIHandler                         = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x048), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0270026B6818 0x48 PreviousUIHandler           ( 0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.NextUIHandler                             = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x050), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0270026B6838 0x50 NextUIHandler               ( 0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.M_Widget                                  = GetObject<Widget>(new IntPtr(p + 0x058), ReversePrism.DataModels.Widget.FromPointer); // 0270026B6858 0x58 M_Widget                    ( 00018658BD60 ModelClassType Widget Widget Widget Pointer )

            return value;
        }
    }
}
