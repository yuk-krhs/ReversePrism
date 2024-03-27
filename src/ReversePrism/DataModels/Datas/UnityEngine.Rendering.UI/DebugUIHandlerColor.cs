using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 ValueToggle                              0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer
    // 070 ColorImage                               0001866CD270 ModelClassType Image Image Image Pointer
    // 078 FieldR                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 080 FieldG                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 088 FieldB                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 090 FieldA                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 098 M_Field                                  000186583770 ModelClassType ColorField ColorField ColorField Pointer
    // 0A0 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerColor
    {
        public Text?                                    NameLabel                               { get; set; }
        public UIFoldout?                               ValueToggle                             { get; set; }
        public Image?                                   ColorImage                              { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldR                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldG                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldB                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldA                                  { get; set; }
        public ColorField?                              M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerColor();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D9330920 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 0270D9330940 0x68 ValueToggle                 ( 0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.ColorImage                                = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0270D9330960 0x70 ColorImage                  ( 0001866CD270 ModelClassType Image Image Image Pointer )
            value.FieldR                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D9330980 0x78 FieldR                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldG                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x080), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D93309A0 0x80 FieldG                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldB                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x088), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D93309C0 0x88 FieldB                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldA                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x090), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D93309E0 0x90 FieldA                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.M_Field                                   = GetObject<ColorField>(new IntPtr(p + 0x098), ReversePrism.DataModels.ColorField.FromPointer); // 0270D9330A00 0x98 M_Field                     ( 000186583770 ModelClassType ColorField ColorField ColorField Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0270D9330A20 0xA0 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
