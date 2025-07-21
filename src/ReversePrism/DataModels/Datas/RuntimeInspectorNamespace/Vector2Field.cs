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
    // 090 LabelX                                   ModelClassType Text Text Text Pointer
    // 098 LabelY                                   ModelClassType Text Text Text Pointer
    // 0A0 IsVector2Int                             ModelPrimitiveType bool bool bool Bool
    public partial class Vector2Field : DataModel
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
            var value   = new Vector2Field() { Pointer= p0 };

            value.InputX                                    = GetObject<BoundInputField>(new IntPtr(p + 0x080), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x80 InputX                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.InputY                                    = GetObject<BoundInputField>(new IntPtr(p + 0x088), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x88 InputY                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.LabelX                                    = GetObject<Text>(new IntPtr(p + 0x090), ReversePrism.DataModels.Text.FromPointer); // 0x90 LabelX                      ( ModelClassType Text Text Text Pointer )
            value.LabelY                                    = GetObject<Text>(new IntPtr(p + 0x098), ReversePrism.DataModels.Text.FromPointer); // 0x98 LabelY                      ( ModelClassType Text Text Text Pointer )
            value.IsVector2Int                              = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsVector2Int                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
