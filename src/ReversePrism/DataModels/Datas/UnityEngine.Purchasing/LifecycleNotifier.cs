using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnDestroyCallback                        ModelClassType Action Action Action Pointer
    public partial class LifecycleNotifier : DataModel
    {
        public Action?                                  OnDestroyCallback                       { get; set; }

        public static LifecycleNotifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LifecycleNotifier() { Pointer= p0 };

            value.OnDestroyCallback                         = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 OnDestroyCallback           ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
