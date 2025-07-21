using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onScene                                  Action`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 018 OffScene                                 ModelClassType Action Action Action Pointer
    // 020 OnUI                                     ModelClassType Action Action Action Pointer
    // 028 OffUI                                    ModelClassType Action Action Action Pointer
    // 030 onUIAct                                  Action`1<string> IL2CPP_TYPE_GENERICINST
    // 038 OnEndMovie                               ModelClassType Action Action Action Pointer
    public partial class CallbackActionSet : DataModel
    {
        public Action?                                  OffScene                                { get; set; }
        public Action?                                  OnUI                                    { get; set; }
        public Action?                                  OffUI                                   { get; set; }
        public Action?                                  OnEndMovie                              { get; set; }

        public static CallbackActionSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackActionSet() { Pointer= p0 };

            value.OffScene                                  = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0x18 OffScene                    ( ModelClassType Action Action Action Pointer )
            value.OnUI                                      = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 OnUI                        ( ModelClassType Action Action Action Pointer )
            value.OffUI                                     = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0x28 OffUI                       ( ModelClassType Action Action Action Pointer )
            value.OnEndMovie                                = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0x38 OnEndMovie                  ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
