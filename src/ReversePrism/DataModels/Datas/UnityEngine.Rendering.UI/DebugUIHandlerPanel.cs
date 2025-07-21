using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameLabel                                ModelClassType Text Text Text Pointer
    // 028 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 030 Viewport                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 Canvas                                   ModelClassType DebugUIHandlerCanvas DebugUIHandlerCanvas DebugUIHandlerCanvas Pointer
    // 040 M_ScrollTransform                        ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 M_ContentTransform                       ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 M_MaskTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 M_ScrollTarget                           ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer
    // 060 M_Panel                                  ModelClassType Panel Panel Panel Pointer
    public partial class DebugUIHandlerPanel : DataModel
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
            var value   = new DebugUIHandlerPanel() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x020), ReversePrism.DataModels.Text.FromPointer); // 0x20 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x28 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.Viewport                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 Viewport                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Canvas                                    = GetObject<DebugUIHandlerCanvas>(new IntPtr(p + 0x038), ReversePrism.DataModels.DebugUIHandlerCanvas.FromPointer); // 0x38 Canvas                      ( ModelClassType DebugUIHandlerCanvas DebugUIHandlerCanvas DebugUIHandlerCanvas Pointer )
            value.M_ScrollTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 M_ScrollTransform           ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ContentTransform                        = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 M_ContentTransform          ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_MaskTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 M_MaskTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ScrollTarget                            = GetObject<DebugUIHandlerWidget>(new IntPtr(p + 0x058), ReversePrism.DataModels.DebugUIHandlerWidget.FromPointer); // 0x58 M_ScrollTarget              ( ModelClassType DebugUIHandlerWidget DebugUIHandlerWidget DebugUIHandlerWidget Pointer )
            value.M_Panel                                   = GetObject<Panel>(new IntPtr(p + 0x060), ReversePrism.DataModels.Panel.FromPointer); // 0x60 M_Panel                     ( ModelClassType Panel Panel Panel Pointer )

            return value;
        }
    }
}
