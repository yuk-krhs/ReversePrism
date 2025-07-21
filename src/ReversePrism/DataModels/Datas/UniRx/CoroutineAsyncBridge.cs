using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Continuation                             ModelClassType Action Action Action Pointer
    // 018 IsCompleted                              ModelPrimitiveType bool bool bool Bool
    public partial class CoroutineAsyncBridge : DataModel
    {
        public Action?                                  Continuation                            { get; set; }
        public bool                                     IsCompleted                             { get; set; }

        public static CoroutineAsyncBridge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoroutineAsyncBridge() { Pointer= p0 };

            value.Continuation                              = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 Continuation                ( ModelClassType Action Action Action Pointer )
            value.IsCompleted                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsCompleted                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
