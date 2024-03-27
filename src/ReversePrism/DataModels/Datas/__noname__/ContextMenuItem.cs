using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayName                              0001866722E0 ModelPrimitiveType string string string String
    // 018 Action                                   000186679A00 ModelClassType Action Action Action Pointer
    public partial class ContextMenuItem
    {
        public string                                   DisplayName                             { get; set; }
        public Action?                                  Action                                  { get; set; }

        public static ContextMenuItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextMenuItem();

            value.DisplayName                               = GetString(new IntPtr(p + 0x010)); // 0270D916CC30 0x10 DisplayName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D916CC50 0x18 Action                      ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
