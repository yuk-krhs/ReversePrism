using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Element                                  ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 Action                                   ModelClassType Action Action Action Pointer
    // 028 actionUserData                           Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class MenuItem : DataModel
    {
        public string                                   Name                                    { get; set; }
        public VisualElement?                           Element                                 { get; set; }
        public Action?                                  Action                                  { get; set; }

        public static MenuItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MenuItem() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Element                                   = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 Element                     ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 Action                      ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
