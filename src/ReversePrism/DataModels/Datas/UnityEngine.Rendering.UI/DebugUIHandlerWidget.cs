using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ColorDefault                             ModelEnumType Color Color Color Int32
    // 030 ColorSelected                            ModelEnumType Color Color Color Int32
    // 040 ParentUIHandler                          ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 048 PreviousUIHandler                        ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 050 NextUIHandler                            ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 058 M_Widget                                 ModelClassType Widget Widget Widget Pointer
    public partial class DebugUIHandlerWidget : DataModel
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
            var value   = new DebugUIHandlerWidget() { Pointer= p0 };

            value.ColorDefault                              = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 ColorDefault                ( ModelEnumType Color Color Color Int32 )
            value.ColorSelected                             = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 ColorSelected               ( ModelEnumType Color Color Color Int32 )
            value.ParentUIHandler                           = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x040), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0x40 ParentUIHandler             ( ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.PreviousUIHandler                         = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x048), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0x48 PreviousUIHandler           ( ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.NextUIHandler                             = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x050), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0x50 NextUIHandler               ( ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.M_Widget                                  = GetObject<Widget>(new IntPtr(p + 0x058), ReversePrism.DataModels.Widget.FromPointer); // 0x58 M_Widget                    ( ModelClassType Widget Widget Widget Pointer )

            return value;
        }
    }
}
