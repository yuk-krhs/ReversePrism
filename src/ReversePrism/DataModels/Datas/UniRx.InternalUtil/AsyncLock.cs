using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 queue                                    Queue`1<Action> IL2CPP_TYPE_GENERICINST
    // 018 IsAcquired                               ModelPrimitiveType bool bool bool Bool
    // 019 HasFaulted                               ModelPrimitiveType bool bool bool Bool
    public partial class AsyncLock : DataModel
    {
        public bool                                     IsAcquired                              { get; set; }
        public bool                                     HasFaulted                              { get; set; }

        public static AsyncLock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncLock() { Pointer= p0 };

            value.IsAcquired                                = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAcquired                  ( ModelPrimitiveType bool bool bool Bool )
            value.HasFaulted                                = GetBool(new IntPtr(p + 0x019)); // 0x19 HasFaulted                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
