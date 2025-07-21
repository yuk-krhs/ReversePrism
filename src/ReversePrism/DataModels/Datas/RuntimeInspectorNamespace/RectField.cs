using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 InputX                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 088 InputY                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 090 InputW                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 098 InputH                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 0A0 LabelX                                   ModelClassType Text Text Text Pointer
    // 0A8 LabelY                                   ModelClassType Text Text Text Pointer
    // 0B0 LabelW                                   ModelClassType Text Text Text Pointer
    // 0B8 LabelH                                   ModelClassType Text Text Text Pointer
    // 0C0 IsRectInt                                ModelPrimitiveType bool bool bool Bool
    public partial class RectField : DataModel
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
            var value   = new RectField() { Pointer= p0 };

            value.InputX                                    = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x80 InputX                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputY                                    = GetObject<BoundInputField>(new IntPtr(p + 0x088), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x88 InputY                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputW                                    = GetObject<BoundInputField>(new IntPtr(p + 0x090), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x90 InputW                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputH                                    = GetObject<BoundInputField>(new IntPtr(p + 0x098), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x98 InputH                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.LabelX                                    = GetObject<Text>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Text.FromPointer); // 0xA0 LabelX                      ( ModelClassType Text Text Text Pointer )
            value.LabelY                                    = GetObject<Text>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Text.FromPointer); // 0xA8 LabelY                      ( ModelClassType Text Text Text Pointer )
            value.LabelW                                    = GetObject<Text>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Text.FromPointer); // 0xB0 LabelW                      ( ModelClassType Text Text Text Pointer )
            value.LabelH                                    = GetObject<Text>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Text.FromPointer); // 0xB8 LabelH                      ( ModelClassType Text Text Text Pointer )
            value.IsRectInt                                 = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsRectInt                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
