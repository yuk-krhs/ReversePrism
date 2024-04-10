using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Action                                   0001866792B0 ModelClassType Action Action Action Pointer
    public partial class Button : DataModel
    {
        public Action?                                  Action                                  { get; set; }

        public static Button? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Button() { Pointer= p0 };

            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0246691DC118 0x48 Action                      ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
