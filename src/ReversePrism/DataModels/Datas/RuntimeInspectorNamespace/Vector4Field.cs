using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 InputX                                   00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 088 InputY                                   00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 090 InputZ                                   00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 098 InputW                                   00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 0A0 LabelX                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0A8 LabelY                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0B0 LabelZ                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0B8 LabelW                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0C0 IsQuaternion                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Vector4Field : DataModel
    {
        public BoundInputField?                         InputX                                  { get; set; }
        public BoundInputField?                         InputY                                  { get; set; }
        public BoundInputField?                         InputZ                                  { get; set; }
        public BoundInputField?                         InputW                                  { get; set; }
        public Text?                                    LabelX                                  { get; set; }
        public Text?                                    LabelY                                  { get; set; }
        public Text?                                    LabelZ                                  { get; set; }
        public Text?                                    LabelW                                  { get; set; }
        public bool                                     IsQuaternion                            { get; set; }

        public static Vector4Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector4Field() { Pointer= p0 };

            value.InputX                                    = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 02466B2486A0 0x80 InputX                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputY                                    = GetObject<BoundInputField>(new IntPtr(p + 0x088), ReversePrism.DataModels.BoundInputField.FromPointer); // 02466B2486C0 0x88 InputY                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputZ                                    = GetObject<BoundInputField>(new IntPtr(p + 0x090), ReversePrism.DataModels.BoundInputField.FromPointer); // 02466B2486E0 0x90 InputZ                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputW                                    = GetObject<BoundInputField>(new IntPtr(p + 0x098), ReversePrism.DataModels.BoundInputField.FromPointer); // 02466B248700 0x98 InputW                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.LabelX                                    = GetObject<Text>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Text.FromPointer); // 02466B248720 0xA0 LabelX                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelY                                    = GetObject<Text>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Text.FromPointer); // 02466B248740 0xA8 LabelY                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelZ                                    = GetObject<Text>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Text.FromPointer); // 02466B248760 0xB0 LabelZ                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelW                                    = GetObject<Text>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Text.FromPointer); // 02466B248780 0xB8 LabelW                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.IsQuaternion                              = GetBool(new IntPtr(p + 0x0C0)); // 02466B2487A0 0xC0 IsQuaternion                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
