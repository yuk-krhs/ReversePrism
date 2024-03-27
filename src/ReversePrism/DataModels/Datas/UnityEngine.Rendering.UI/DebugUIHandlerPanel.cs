using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 028 ScrollRect                               0001866F81F0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 030 Viewport                                 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 Canvas                                   0001866A1570 ModelClassType DebugUIHandlerCanvas DebugUIHandlerCanvas DebugUIHandlerCanvas Pointer
    // 040 M_ScrollTransform                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 M_ContentTransform                       000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 M_MaskTransform                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 M_ScrollTarget                           0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 060 M_Panel                                  000186588470 ModelClassType Panel Panel Panel Pointer
    public partial class DebugUIHandlerPanel
    {
        public Text?                                    NameLabel                               { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public RectTransform?                           Viewport                                { get; set; }
        public DebugUIHandlerCanvas?                    Canvas                                  { get; set; }
        public RectTransform?                           M_ScrollTransform                       { get; set; }
        public RectTransform?                           M_ContentTransform                      { get; set; }
        public RectTransform?                           M_MaskTransform                         { get; set; }
        public DebugUIHandlerWidget?                    M_ScrollTarget                          { get; set; }
        public Panel?                                   M_Panel                                 { get; set; }

        public static DebugUIHandlerPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerPanel();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x020), ReversePrism.DataModels.Text.FromPointer); // 0270D931B9F0 0x20 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D931BA10 0x28 ScrollRect                  ( 0001866F81F0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.Viewport                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D931BA30 0x30 Viewport                    ( 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Canvas                                    = GetObject<DebugUIHandlerCanvas>(new IntPtr(p + 0x038), ReversePrism.DataModels.DebugUIHandlerCanvas.FromPointer); // 0270D931BA50 0x38 Canvas                      ( 0001866A1570 ModelClassType DebugUIHandlerCanvas DebugUIHandlerCanvas DebugUIHandlerCanvas Pointer )
            value.M_ScrollTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D931BA70 0x40 M_ScrollTransform           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ContentTransform                        = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D931BA90 0x48 M_ContentTransform          ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_MaskTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D931BAB0 0x50 M_MaskTransform             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ScrollTarget                            = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x058), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0270D931BAD0 0x58 M_ScrollTarget              ( 0001865BF940 ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.M_Panel                                   = GetObject<Panel>(new IntPtr(p + 0x060), ReversePrism.DataModels.Panel.FromPointer); // 0270D931BAF0 0x60 M_Panel                     ( 000186588470 ModelClassType Panel Panel Panel Pointer )

            return value;
        }
    }
}
