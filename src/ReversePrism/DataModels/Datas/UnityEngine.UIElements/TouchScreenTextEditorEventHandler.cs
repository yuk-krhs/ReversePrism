using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_TouchKeyboardPoller                    000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 028 M_TouchKeyboardAllowsInPlaceEditing      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_IsClicking                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TouchScreenTextEditorEventHandler
    {
        public IVisualElementScheduledItem?             M_TouchKeyboardPoller                   { get; set; }
        public bool                                     M_TouchKeyboardAllowsInPlaceEditing     { get; set; }
        public bool                                     M_IsClicking                            { get; set; }

        public static TouchScreenTextEditorEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchScreenTextEditorEventHandler();

            value.M_TouchKeyboardPoller                     = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 02700671A9F8 0x20 M_TouchKeyboardPoller       ( 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.M_TouchKeyboardAllowsInPlaceEditing       = GetBool(new IntPtr(p + 0x028)); // 02700671AA18 0x28 M_TouchKeyboardAllowsInPlaceEditing ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsClicking                              = GetBool(new IntPtr(p + 0x029)); // 02700671AA38 0x29 M_IsClicking                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
