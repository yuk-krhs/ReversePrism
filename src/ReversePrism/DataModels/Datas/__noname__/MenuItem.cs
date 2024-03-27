using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Element                                  0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 Action                                   000186679A00 ModelClassType Action Action Action Pointer
    // 028 actionUserData                           Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class MenuItem
    {
        public string                                   Name                                    { get; set; }
        public VisualElement?                           Element                                 { get; set; }
        public Action?                                  Action                                  { get; set; }

        public static MenuItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MenuItem();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02700670FC38 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Element                                   = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 02700670FC58 0x18 Element                     ( 0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 02700670FC78 0x20 Action                      ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
