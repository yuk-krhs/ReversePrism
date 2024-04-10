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
    // 080 FieldZ                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 088 FieldW                                   0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer
    // 090 M_Field                                  00018658B990 ModelClassType Vector4Field Vector4Field Vector4Field Pointer
    // 098 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerVector4 : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public UIFoldout?                               ValueToggle                             { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldX                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldY                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldZ                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldW                                  { get; set; }
        public Vector4Field?                            M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerVector4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerVector4() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 02466939E558 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 02466939E578 0x68 ValueToggle                 ( 0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.FieldX                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x070), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 02466939E598 0x70 FieldX                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldY                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 02466939E5B8 0x78 FieldY                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldZ                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x080), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 02466939E5D8 0x80 FieldZ                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldW                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x088), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 02466939E5F8 0x88 FieldW                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.M_Field                                   = GetObject<Vector4Field>(new IntPtr(p + 0x090), ReversePrism.DataModels.Vector4Field.FromPointer); // 02466939E618 0x90 M_Field                     ( 00018658B990 ModelClassType Vector4Field Vector4Field Vector4Field Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x098), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 02466939E638 0x98 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
