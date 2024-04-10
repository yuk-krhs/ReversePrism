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
    // 070 FieldX                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 078 FieldY                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 080 M_Field                                  00018658AF30 ModelClassType Vector2Field Vector2Field Vector2Field Pointer
    // 088 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerVector2 : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public UIFoldout?                               ValueToggle                             { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldX                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldY                                  { get; set; }
        public Vector2Field?                            M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerVector2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerVector2() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 02466939D0C0 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 02466939D0E0 0x68 ValueToggle                 ( 0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.FieldX                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x070), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 02466939D100 0x70 FieldX                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldY                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 02466939D120 0x78 FieldY                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.M_Field                                   = GetObject<Vector2Field>(new IntPtr(p + 0x080), ReversePrism.DataModels.Vector2Field.FromPointer); // 02466939D140 0x80 M_Field                     ( 00018658AF30 ModelClassType Vector2Field Vector2Field Vector2Field Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x088), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 02466939D160 0x88 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
