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
    // 088 M_Field                                  00018658B470 ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 090 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerVector3
    {
        public Text?                                    NameLabel                               { get; set; }
        public UIFoldout?                               ValueToggle                             { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldX                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldY                                  { get; set; }
        public DebugUIHandlerIndirectFloatField?        FieldZ                                  { get; set; }
        public Vector3Field?                            M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerVector3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerVector3();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D9344128 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 0270D9344148 0x68 ValueToggle                 ( 0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.FieldX                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x070), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D9344168 0x70 FieldX                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldY                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D9344188 0x78 FieldY                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.FieldZ                                    = GetObject<DebugUIHandlerIndirectFloatField>(new IntPtr(p + 0x080), ReversePrism.DataModels.DebugUIHandlerIndirectFloatField.FromPointer); // 0270D93441A8 0x80 FieldZ                      ( 0001866A3550 ModelClassType DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField DebugUIHandlerIndirectFloatField Pointer )
            value.M_Field                                   = GetObject<Vector3Field>(new IntPtr(p + 0x088), ReversePrism.DataModels.Vector3Field.FromPointer); // 0270D93441C8 0x88 M_Field                     ( 00018658B470 ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x090), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0270D93441E8 0x90 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
