using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_TouchKeyboardPoller                    ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 028 M_TouchKeyboardAllowsInPlaceEditing      ModelPrimitiveType bool bool bool Bool
    // 029 M_IsClicking                             ModelPrimitiveType bool bool bool Bool
    public partial class TouchScreenTextEditorEventHandler : DataModel
    {
        public IVisualElementScheduledItem?             M_TouchKeyboardPoller                   { get; set; }
        public bool                                     M_TouchKeyboardAllowsInPlaceEditing     { get; set; }
        public bool                                     M_IsClicking                            { get; set; }

        public static TouchScreenTextEditorEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchScreenTextEditorEventHandler() { Pointer= p0 };

            value.M_TouchKeyboardPoller                     = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0x20 M_TouchKeyboardPoller       ( ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.M_TouchKeyboardAllowsInPlaceEditing       = GetBool(new IntPtr(p + 0x028)); // 0x28 M_TouchKeyboardAllowsInPlaceEditing ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsClicking                              = GetBool(new IntPtr(p + 0x029)); // 0x29 M_IsClicking                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
