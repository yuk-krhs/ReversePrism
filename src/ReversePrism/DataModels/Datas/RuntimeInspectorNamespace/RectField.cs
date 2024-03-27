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
    // 090 InputW                                   00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 098 InputH                                   00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 0A0 LabelX                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0A8 LabelY                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0B0 LabelW                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0B8 LabelH                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0C0 IsRectInt                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RectField
    {
        public BoundInputField?                         InputX                                  { get; set; }
        public BoundInputField?                         InputY                                  { get; set; }
        public BoundInputField?                         InputW                                  { get; set; }
        public BoundInputField?                         InputH                                  { get; set; }
        public Text?                                    LabelX                                  { get; set; }
        public Text?                                    LabelY                                  { get; set; }
        public Text?                                    LabelW                                  { get; set; }
        public Text?                                    LabelH                                  { get; set; }
        public bool                                     IsRectInt                               { get; set; }

        public static RectField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectField();

            value.InputX                                    = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E8290 0x80 InputX                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputY                                    = GetObject<BoundInputField>(new IntPtr(p + 0x088), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E82B0 0x88 InputY                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputW                                    = GetObject<BoundInputField>(new IntPtr(p + 0x090), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E82D0 0x90 InputW                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputH                                    = GetObject<BoundInputField>(new IntPtr(p + 0x098), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E82F0 0x98 InputH                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.LabelX                                    = GetObject<Text>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8310 0xA0 LabelX                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelY                                    = GetObject<Text>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8330 0xA8 LabelY                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelW                                    = GetObject<Text>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8350 0xB0 LabelW                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelH                                    = GetObject<Text>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8370 0xB8 LabelH                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.IsRectInt                                 = GetBool(new IntPtr(p + 0x0C0)); // 0270DB1E8390 0xC0 IsRectInt                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
