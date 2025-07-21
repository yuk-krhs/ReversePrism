using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_ImguiEvent                             ModelClassType Event Event Event Pointer
    // 028 M_Changed                                ModelPrimitiveType bool bool bool Bool
    public partial class KeyboardTextEditorEventHandler : DataModel
    {
        public Event?                                   M_ImguiEvent                            { get; set; }
        public bool                                     M_Changed                               { get; set; }

        public static KeyboardTextEditorEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyboardTextEditorEventHandler() { Pointer= p0 };

            value.M_ImguiEvent                              = GetObject<Event>(new IntPtr(p + 0x020), ReversePrism.DataModels.Event.FromPointer); // 0x20 M_ImguiEvent                ( ModelClassType Event Event Event Pointer )
            value.M_Changed                                 = GetBool(new IntPtr(p + 0x028)); // 0x28 M_Changed                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
