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
    // 090 LabelX                                   000186631C00 ModelClassType Text Text Text Pointer
    // 098 LabelY                                   000186631C00 ModelClassType Text Text Text Pointer
    // 0A0 IsVector2Int                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Vector2Field
    {
        public BoundInputField?                         InputX                                  { get; set; }
        public BoundInputField?                         InputY                                  { get; set; }
        public Text?                                    LabelX                                  { get; set; }
        public Text?                                    LabelY                                  { get; set; }
        public bool                                     IsVector2Int                            { get; set; }

        public static Vector2Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2Field();

            value.InputX                                    = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E8600 0x80 InputX                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputY                                    = GetObject<BoundInputField>(new IntPtr(p + 0x088), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1E8620 0x88 InputY                      ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.LabelX                                    = GetObject<Text>(new IntPtr(p + 0x090), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8640 0x90 LabelX                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.LabelY                                    = GetObject<Text>(new IntPtr(p + 0x098), ReversePrism.DataModels.Text.FromPointer); // 0270DB1E8660 0x98 LabelY                      ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.IsVector2Int                              = GetBool(new IntPtr(p + 0x0A0)); // 0270DB1E8680 0xA0 IsVector2Int                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
