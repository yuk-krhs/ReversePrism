using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     ConcurrentQueue`1<PooledTweenCallback> IL2CPP_TYPE_GENERICINST
    // 010 RunDelegate                              0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer
    // 018 Continuation                             0001866792B0 ModelClassType Action Action Action Pointer
    public partial class PooledTweenCallback
    {
        public TweenCallback?                           RunDelegate                             { get; set; }
        public Action?                                  Continuation                            { get; set; }

        public static PooledTweenCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PooledTweenCallback();

            value.RunDelegate                               = GetObject<TweenCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.TweenCallback.FromPointer); // 0270DBF16628 0x10 RunDelegate                 ( 0001866C0A30 ModelClassType TweenCallback TweenCallback TweenCallback Pointer )
            value.Continuation                              = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270DBF16648 0x18 Continuation                ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
