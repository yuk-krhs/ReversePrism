using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onScene                                  Action`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 018 OffScene                                 000186679A00 ModelClassType Action Action Action Pointer
    // 020 OnUI                                     000186679A00 ModelClassType Action Action Action Pointer
    // 028 OffUI                                    000186679A00 ModelClassType Action Action Action Pointer
    // 030 onUIAct                                  Action`1<string> IL2CPP_TYPE_GENERICINST
    public partial class CallbackActionSet
    {
        public Action?                                  OffScene                                { get; set; }
        public Action?                                  OnUI                                    { get; set; }
        public Action?                                  OffUI                                   { get; set; }

        public static CallbackActionSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackActionSet();

            value.OffScene                                  = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D4DC11E0 0x18 OffScene                    ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnUI                                      = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0270D4DC1200 0x20 OnUI                        ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OffUI                                     = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0270D4DC1220 0x28 OffUI                       ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
