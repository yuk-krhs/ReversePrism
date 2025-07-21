using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 WaitTimeout                              int IL2CPP_TYPE_I4
    // 000 MAX_WAITHANDLES                          int IL2CPP_TYPE_I4
    // 018 waitHandle                               <int> IL2CPP_TYPE_I
    // 020 SafeWaitHandle                           ModelClassType SafeWaitHandle SafeWaitHandle SafeWaitHandle Pointer
    // 028 HasThreadAffinity                        ModelPrimitiveType bool bool bool Bool
    // 000 WAIT_OBJECT_0                            int IL2CPP_TYPE_I4
    // 000 WAIT_ABANDONED                           int IL2CPP_TYPE_I4
    // 000 WAIT_FAILED                              int IL2CPP_TYPE_I4
    // 000 ERROR_TOO_MANY_POSTS                     int IL2CPP_TYPE_I4
    // 000 ERROR_NOT_OWNED_BY_CALLER                int IL2CPP_TYPE_I4
    // 000 InvalidHandle                            <int> IL2CPP_TYPE_I
    // 000 MaxWaitHandles                           int IL2CPP_TYPE_I4
    public partial class WaitHandle : DataModel
    {
        public SafeWaitHandle?                          SafeWaitHandle                          { get; set; }
        public bool                                     HasThreadAffinity                       { get; set; }

        public static WaitHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitHandle() { Pointer= p0 };

            value.SafeWaitHandle                            = GetObject<SafeWaitHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.SafeWaitHandle.FromPointer); // 0x20 SafeWaitHandle              ( ModelClassType SafeWaitHandle SafeWaitHandle SafeWaitHandle Pointer )
            value.HasThreadAffinity                         = GetBool(new IntPtr(p + 0x028)); // 0x28 HasThreadAffinity           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
