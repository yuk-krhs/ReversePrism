using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Prefab                                   000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class DebugUIPrefabBundle
    {
        public string                                   Type                                    { get; set; }
        public RectTransform?                           Prefab                                  { get; set; }

        public static DebugUIPrefabBundle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIPrefabBundle();

            value.Type                                      = GetString(new IntPtr(p + 0x010)); // 0270D931B120 0x10 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Prefab                                    = GetObject<RectTransform>(new IntPtr(p + 0x018), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D931B140 0x18 Prefab                      ( 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
