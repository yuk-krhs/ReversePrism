using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 ValueToggle                              ModelClassType UIFoldout UIFoldout UIFoldout Pointer
    // 070 FieldX                                   ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 078 FieldY                                   ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 080 M_Field                                  ModelClassType Vector2Field Vector2Field Vector2Field Pointer
    // 088 M_Container                              ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
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

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 0x68 ValueToggle                 ( ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.FieldX                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x070), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0x70 FieldX                      ( ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldY                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0x78 FieldY                      ( ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.M_Field                                   = GetObject<Vector2Field>(new IntPtr(p + 0x080), ReversePrism.DataModels.Vector2Field.FromPointer); // 0x80 M_Field                     ( ModelClassType Vector2Field Vector2Field Vector2Field Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x088), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0x88 M_Container                 ( ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
